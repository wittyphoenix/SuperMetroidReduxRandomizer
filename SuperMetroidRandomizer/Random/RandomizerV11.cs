﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using SuperMetroidRandomizer.IO;
using SuperMetroidRandomizer.Net;
using SuperMetroidRandomizer.Properties;
using SuperMetroidRandomizer.Rom;

namespace SuperMetroidRandomizer.Random
{
    public enum RandomizerDifficulty
    {
        None,
        Casual,
        Speedrunner,
        Masochist,
        Insane,
    }

    public class RandomizerV11
    {
        private static SeedRandom random;
        private List<ItemType> haveItems;
        private List<ItemType> itemPool;
        private readonly int seed;
        private readonly IRomLocations romLocations;
        private RandomizerLog log;
        private string inputfile;
        private List<string> HiddenItems = new List<string>();
        private List<string> UnusedItems = new List<string>();
        private List<string> NormalItems = new List<string>();
        private string[] FirstDupe = {"x09", "x12", "x24", "x3D", "x8C", "x90" };
        private string[] LastDupe = { "x0A", "x13", "x25", "x3E", "x8D", "x91" };
        private string[] LastDupeEsc = { "\x0A", "\x13", "\x25", "\x3E", "\x8D", "\x91" };
        private long[] DupeAddress = { 0x17cd6, 0x17d18, 0x17d90, 0x17e3a, 0x17f26, 0x17f3e};
        private byte[] RomImage;
        


        public RandomizerV11(int seed, IRomLocations romLocations, RandomizerLog log, string inputfile)
        {
            random = new SeedRandom(seed);
            this.romLocations = romLocations;
            this.seed = seed;
            this.log = log;
            this.inputfile = inputfile;
        }
        
        public string CreateRom(string filename, bool spoilerOnly = false)
        {
            if (filename.Contains("\\") && !Directory.Exists(filename.Substring(0, filename.LastIndexOf('\\'))))
            {
                Directory.CreateDirectory(filename.Substring(0, filename.LastIndexOf('\\')));
            }

            GenerateItemList();
            GenerateItemPositions();

            if (spoilerOnly)
            {
                return log?.GetLogOutput();
            }

            WriteRom(filename);

            return "";
        }

        private void WriteRom(string filename)
        {
            string usedFilename = FileName.Fix(filename, string.Format(romLocations.SeedFileString, seed));
            var hideLocations = !(romLocations is RomLocationsCasual);
            if (Settings.Default.UseCustomSettings && !Settings.Default.CustomHiddenItems)
                hideLocations = false;
            try
            {
                RomImage = File.ReadAllBytes(inputfile);
            }
            catch {
                MessageBox.Show("Invalid input file.","File Read Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            using (var rom = new FileStream(usedFilename, FileMode.OpenOrCreate))
            {
                rom.Write(RomImage, 0, 3145728);
                decimal useditems = 0;
                decimal chargeitems = 0;
                foreach (var location in romLocations.Locations)
                {
                    rom.Seek(location.Address, SeekOrigin.Begin);
                    var newItem = new byte[2];

                    if (!location.NoHidden && location.Item.Type != ItemType.Nothing && location.Item.Type != ItemType.ChargeBeam && location.ItemStorageType == ItemStorageType.Normal)
                    {
                        // hide the item half of the time (to be a jerk)
                        if (hideLocations && random.Next(2) == 0)
                        {
                            location.ItemStorageType = ItemStorageType.Hidden;
                        }
                    }

                    switch (location.ItemStorageType)
                    {
                        case ItemStorageType.Normal:
                            newItem = StringToByteArray(location.Item.Normal);
                            NormalItems.Add(location.ItemID);
                            break;
                        case ItemStorageType.Hidden:
                            newItem = StringToByteArray(location.Item.Hidden);
                            HiddenItems.Add(location.ItemID);
                            break;
                        case ItemStorageType.Chozo:
                            newItem = StringToByteArray(location.Item.Chozo);
                            NormalItems.Add(location.ItemID);
                            break;
                    }

                    rom.Write(newItem, 0, 2);

                    if (location.Item.Type == ItemType.Nothing)
                    {
                        // give same index as morph ball
                        rom.Seek(location.Address + 4, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\x1a"), 0, 1);
                        if (location.ItemID != null)
                        {
                            UnusedItems.Add(location.ItemID);
                        }
                        NormalItems.Remove(location.ItemID);
                        HiddenItems.Remove(location.ItemID);
                    }
                    else
                    {
                        useditems += 1;
                    }
                    
                    //assign blank icon to map to maintain secret
                    if (location.Item.Type == ItemType.Nothing || location.ItemStorageType == ItemStorageType.Hidden)
                    {
                        rom.Seek(location.MapAddress + 6, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\x08"), 0, 1);
                    }

                    if (location.Item.Type == ItemType.ChargeBeam)
                    {
                        // we have 4 copies of charge to reduce tedium, give them all the same index
                        rom.Seek(location.Address + 4, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\xff"), 0, 1);
                        rom.Seek(location.MapAddress, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\xff"), 0, 1);
                        chargeitems += 1;
                    }
                }

                //remove extra charge beams from the item count
                useditems = useditems - (chargeitems - 1);

                //write total items for % calc
                rom.Seek(0x17a92, SeekOrigin.Begin);
                byte[] useditemsarray = { decimal.ToByte(useditems) };
                rom.Write(useditemsarray, 0, 1);
                rom.Seek(0x5e651, SeekOrigin.Begin);
                rom.Write(useditemsarray, 0, 1);

                int cnt = 0;
                foreach (var dupe in FirstDupe)
                {
                    if (HiddenItems.Contains(FirstDupe[cnt]) && UnusedItems.Contains(LastDupe[cnt]))
                    {
                        rom.Seek(DupeAddress[cnt] + 2, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\xff\xff"), 0, 2);
                    }
                    else if (UnusedItems.Contains(FirstDupe[cnt]) && HiddenItems.Contains(LastDupe[cnt]))
                    {
                        rom.Seek(DupeAddress[cnt], SeekOrigin.Begin);
                        rom.Write(StringToByteArray(LastDupeEsc[cnt]), 0, 1);
                        rom.Seek(DupeAddress[cnt] + 2, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\xff\xff"), 0, 2);
                    }
                    else if ((NormalItems.Contains(FirstDupe[cnt]) && HiddenItems.Contains(LastDupe[cnt])) || (NormalItems.Contains(FirstDupe[cnt]) && UnusedItems.Contains(LastDupe[cnt])))
                    {
                        rom.Seek(DupeAddress[cnt] + 6, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\x0C"), 0, 1);
                        rom.Seek(DupeAddress[cnt] + 2, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\xff\xff"), 0, 2);
                    }
                    else if ((HiddenItems.Contains(FirstDupe[cnt]) && NormalItems.Contains(LastDupe[cnt])) || (UnusedItems.Contains(FirstDupe[cnt]) && NormalItems.Contains(LastDupe[cnt])))
                    {
                        rom.Seek(DupeAddress[cnt] + 6, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\x0C"), 0, 1);
                        rom.Seek(DupeAddress[cnt], SeekOrigin.Begin);
                        rom.Write(StringToByteArray(LastDupeEsc[cnt]), 0, 1);
                        rom.Seek(DupeAddress[cnt] + 2, SeekOrigin.Begin);
                        rom.Write(StringToByteArray("\xff\xff"), 0, 2);
                    }
                    cnt = cnt + 1;
                }

                WriteSeedInRom(rom);
                WriteControls(rom);

                rom.Close();
            }

            if (log != null)
            {
                log.WriteLog(usedFilename);
            }
        }

        private void WriteControls(FileStream rom)
        {
            foreach (var address in Controller.ShotAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsShot]), 0, 2);
            }

            foreach (var address in Controller.JumpAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsJump]), 0, 2);
            }

            foreach (var address in Controller.DashAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsDash]), 0, 2);
            }

            foreach (var address in Controller.ItemSelectAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsItemSelect]), 0, 2);
            }

            foreach (var address in Controller.ItemCancelAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsItemCancel]), 0, 2);
            }

            foreach (var address in Controller.AngleUpAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsAngleUp]), 0, 2);
            }

            foreach (var address in Controller.AngleDownAddresses)
            {
                rom.Seek(address, SeekOrigin.Begin);

                rom.Write(StringToByteArray(Controller.Buttons[Settings.Default.ControlsAngleDown]), 0, 2);
            }
        }

        private void WriteSeedInRom(FileStream rom)
        {
            string seedStr = string.Format(romLocations.SeedRomString, RandomizerVersion.Current, seed.ToString().PadLeft(7, '0')).PadRight(21).Substring(0, 21);
            rom.Seek(0x7fc0, SeekOrigin.Begin);
            rom.Write(StringToByteArray(seedStr), 0, 21);
        }

        private static byte[] StringToByteArray(string input)
        {
            var retVal = new byte[input.Length];
            var i = 0;

            foreach (var ch in input)
            {
                retVal[i] = (byte)ch;
                i++;
            }

            return retVal;
        }

        private void GenerateItemPositions()
        {
            do
            {
                var currentLocations = romLocations.GetAvailableLocations(haveItems);
                var candidateItemList = new List<ItemType>();

                // Generate candidate item list
                foreach (var candidateItem in itemPool)
                {
                    haveItems.Add(candidateItem);

                    var newLocations = romLocations.GetAvailableLocations(haveItems);

                    if (newLocations.Count > currentLocations.Count)
                    {
                        romLocations.TryInsertCandidateItem(currentLocations, candidateItemList, candidateItem);
                    }

                    haveItems.Remove(candidateItem);
                }

                // Grab an item from the candidate list if there are any, otherwise, grab a random item
                if (candidateItemList.Count > 0)
                {
                    var insertedItem = candidateItemList[random.Next(candidateItemList.Count)];

                    itemPool.Remove(insertedItem);
                    haveItems.Add(insertedItem);

                    int insertedLocation = romLocations.GetInsertedLocation(currentLocations, insertedItem, random);
                    currentLocations[insertedLocation].Item = new Item(insertedItem);

                    if (log != null)
                    {
                        log.AddOrderedItem(currentLocations[insertedLocation]);
                    }
                }
                else
                {
                    ItemType insertedItem = romLocations.GetInsertedItem(currentLocations, itemPool, random);

                    itemPool.Remove(insertedItem);
                    haveItems.Add(insertedItem);

                    int insertedLocation = romLocations.GetInsertedLocation(currentLocations, insertedItem, random);
                    currentLocations[insertedLocation].Item = new Item(insertedItem);
                }
            } while (itemPool.Count > 0);

            var unavailableLocations = romLocations.GetUnavailableLocations(haveItems);

            foreach (var unavailableLocation in unavailableLocations)
            {
                unavailableLocation.Item = new Item(ItemType.Nothing);
            }

            if (log != null)
            {
                log.AddGeneratedItems(romLocations.Locations);
            }
        }

        private void GenerateItemList()
        {
            romLocations.ResetLocations();
            haveItems = new List<ItemType>();
            if (Settings.Default.UseCustomSettings)
                itemPool = CreateItemPool(random);
            else
                itemPool = romLocations.GetItemPool(random);
            var unavailableLocations = romLocations.GetUnavailableLocations(itemPool);

            for (int i = itemPool.Count; i < 100 - unavailableLocations.Count; i++)
            {
                itemPool.Add(ItemType.Nothing);
            }
        }

        private List<ItemType> CreateItemPool(SeedRandom random)
        {
            List<ItemType> pool = new List<ItemType>();

            switch (Settings.Default.CustomRouteGen)
            {
                case "Masochist":
                    pool.AddRange(new List<ItemType>
                                    {
                                        ItemType.MorphingBall, ItemType.Bomb, ItemType.ChargeBeam,
                                        ItemType.Spazer, ItemType.VariaSuit, ItemType.HiJumpBoots,
                                        ItemType.SpeedBooster, ItemType.WaveBeam, ItemType.GrappleBeam,
                                        ItemType.SpringBall, ItemType.IceBeam, ItemType.XRayScope,
                                        ItemType.ReserveTank
                                    });
                    break;
                default:
                    pool.AddRange(new List<ItemType>
                                    {
                                        ItemType.MorphingBall, ItemType.Bomb, ItemType.ChargeBeam,
                                        ItemType.Spazer, ItemType.VariaSuit, ItemType.HiJumpBoots,
                                        ItemType.SpeedBooster, ItemType.WaveBeam, ItemType.GrappleBeam,
                                        ItemType.GravitySuit, ItemType.SpaceJump, ItemType.SpringBall,
                                        ItemType.PlasmaBeam, ItemType.IceBeam, ItemType.ScrewAttack,
                                        ItemType.XRayScope, ItemType.ReserveTank, ItemType.ReserveTank,
                                        ItemType.ReserveTank, ItemType.ReserveTank
                                    });
                    break;
            }

            decimal addMissiles = Settings.Default.CustomNormalMissiles / 5;
            decimal addMissilesMax = Settings.Default.CustomNormalMissilesMax / 5;
            decimal addSMissiles = Settings.Default.CustomSuperMissiles / 5;
            decimal addSMissilesMax = Settings.Default.CustomSuperMissilesMax / 5;
            decimal addPBombs = Settings.Default.CustomPowerBombs / 5;
            decimal addPBombsMax = Settings.Default.CustomPowerBombsMax / 5;
            decimal addETanks = Settings.Default.CustomEnergyTanks;
            decimal addETanksMax = Settings.Default.CustomEnergyTanksMax;

            for (int i = 0; i < addMissiles; i++)
                pool.Add(ItemType.Missile);
            for (int i = 0; i < addSMissiles; i++)
                pool.Add(ItemType.SuperMissile);
            for (int i = 0; i < addPBombs; i++)
                pool.Add(ItemType.PowerBomb);
            for (int i = 0; i < addETanks; i++)
                pool.Add(ItemType.EnergyTank);
            
            if (pool.Count < 100 && (Settings.Default.CustomRandomBlanks || Settings.Default.CustomRandomNoBlanks))
            {
                while (pool.Count < 100)
                {
                    int rand = 0; 
                    if (Settings.Default.CustomRandomBlanks)
                        rand = random.Next(8);
                    else if (Settings.Default.CustomRandomNoBlanks)
                        rand = random.Next(4);
                    switch (rand)
                    {
                        case 0:
                            if (addMissiles < addMissilesMax)
                            {
                                pool.Add(ItemType.Missile);
                                ++addMissiles;
                            }
                            break;
                        case 1:
                            if (addSMissiles < addSMissilesMax)
                            {
                                pool.Add(ItemType.SuperMissile);
                                ++addSMissiles;
                            }
                            break;
                        case 2:
                            if (addPBombs < addPBombsMax)
                            {
                                pool.Add(ItemType.PowerBomb);
                                ++addPBombs;
                            }
                            break;
                        case 3:
                            if (addETanks < addETanksMax)
                            {
                                pool.Add(ItemType.EnergyTank);
                                ++addETanks;
                            }
                            break;
                        default:
                            pool.Add(ItemType.Nothing);
                            break;
                    }
                }
            }

            return pool;
        }
    }
}
