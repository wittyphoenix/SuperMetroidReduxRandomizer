using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SuperMetroidRandomizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var MainFunction = new MainFunction();
            MainFunction.CreateRom("Speedrunner", "C:\\Users\\sjmcg\\OneDrive\\Documents\\Metroid\\Randomizer\\Input\\Dedux Rando Compatible.sfc", "Y:\\snes\\Super Metroid Dedux Rando.sfc");
            
        }


    }
}
