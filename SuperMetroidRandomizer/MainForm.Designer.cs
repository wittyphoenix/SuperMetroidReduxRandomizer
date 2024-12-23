namespace SuperMetroidRandomizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.output = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.suitlessForced = new System.Windows.Forms.RadioButton();
            this.suitlessPossible = new System.Windows.Forms.RadioButton();
            this.suitlessDisabled = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFilename = new System.Windows.Forms.TextBox();
            this.seed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputselect = new System.Windows.Forms.Button();
            this.inputfile = new System.Windows.Forms.TextBox();
            this.inputlabel = new System.Windows.Forms.Label();
            this.CustomV11 = new System.Windows.Forms.Button();
            this.randomSpoiler = new System.Windows.Forms.Button();
            this.createSpoilerLog = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.randomizerDifficulty = new System.Windows.Forms.ComboBox();
            this.controlsV11 = new System.Windows.Forms.Button();
            this.browseV11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputV11 = new System.Windows.Forms.TextBox();
            this.seedV11 = new System.Windows.Forms.TextBox();
            this.createV11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filenameV11 = new System.Windows.Forms.TextBox();
            this.controls = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AcceptsReturn = true;
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(9, 157);
            this.output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(769, 364);
            this.output.TabIndex = 1;
            // 
            // process
            // 
            this.process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.process.Location = new System.Drawing.Point(668, 12);
            this.process.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(112, 35);
            this.process.TabIndex = 2;
            this.process.Text = "Create";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.suitlessForced);
            this.groupBox1.Controls.Add(this.suitlessPossible);
            this.groupBox1.Controls.Add(this.suitlessDisabled);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(144, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suitless Maridia";
            // 
            // suitlessForced
            // 
            this.suitlessForced.AutoSize = true;
            this.suitlessForced.Location = new System.Drawing.Point(10, 103);
            this.suitlessForced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suitlessForced.Name = "suitlessForced";
            this.suitlessForced.Size = new System.Drawing.Size(84, 24);
            this.suitlessForced.TabIndex = 2;
            this.suitlessForced.TabStop = true;
            this.suitlessForced.Text = "Forced";
            this.suitlessForced.UseVisualStyleBackColor = true;
            // 
            // suitlessPossible
            // 
            this.suitlessPossible.AutoSize = true;
            this.suitlessPossible.Location = new System.Drawing.Point(10, 68);
            this.suitlessPossible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suitlessPossible.Name = "suitlessPossible";
            this.suitlessPossible.Size = new System.Drawing.Size(93, 24);
            this.suitlessPossible.TabIndex = 1;
            this.suitlessPossible.Text = "Possible";
            this.suitlessPossible.UseVisualStyleBackColor = true;
            // 
            // suitlessDisabled
            // 
            this.suitlessDisabled.AutoSize = true;
            this.suitlessDisabled.Checked = true;
            this.suitlessDisabled.Location = new System.Drawing.Point(10, 31);
            this.suitlessDisabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suitlessDisabled.Name = "suitlessDisabled";
            this.suitlessDisabled.Size = new System.Drawing.Size(96, 24);
            this.suitlessDisabled.TabIndex = 0;
            this.suitlessDisabled.TabStop = true;
            this.suitlessDisabled.Text = "Disabled";
            this.suitlessDisabled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output Filename (<seed> is replaced with file seed, <date> is replaced with date)" +
    "";
            // 
            // outputFilename
            // 
            this.outputFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFilename.Location = new System.Drawing.Point(162, 117);
            this.outputFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputFilename.Name = "outputFilename";
            this.outputFilename.Size = new System.Drawing.Size(570, 26);
            this.outputFilename.TabIndex = 6;
            this.outputFilename.Text = "SM Random <seed>.sfc";
            this.outputFilename.TextChanged += new System.EventHandler(this.outputFilename_TextChanged);
            this.outputFilename.Leave += new System.EventHandler(this.filename_Leave);
            // 
            // seed
            // 
            this.seed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seed.Location = new System.Drawing.Point(162, 57);
            this.seed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(616, 26);
            this.seed.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seed (leave blank to generate new random ROM)";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 574);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputselect);
            this.tabPage1.Controls.Add(this.inputfile);
            this.tabPage1.Controls.Add(this.inputlabel);
            this.tabPage1.Controls.Add(this.CustomV11);
            this.tabPage1.Controls.Add(this.randomSpoiler);
            this.tabPage1.Controls.Add(this.createSpoilerLog);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.randomizerDifficulty);
            this.tabPage1.Controls.Add(this.controlsV11);
            this.tabPage1.Controls.Add(this.browseV11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.outputV11);
            this.tabPage1.Controls.Add(this.seedV11);
            this.tabPage1.Controls.Add(this.createV11);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.filenameV11);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(793, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Randomizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputselect
            // 
            this.inputselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputselect.Image = global::SuperMetroidRandomizer.Properties.Resources.MenuFileSaveIcon;
            this.inputselect.Location = new System.Drawing.Point(739, 133);
            this.inputselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputselect.Name = "inputselect";
            this.inputselect.Size = new System.Drawing.Size(38, 38);
            this.inputselect.TabIndex = 39;
            this.inputselect.UseVisualStyleBackColor = true;
            this.inputselect.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputfile
            // 
            this.inputfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputfile.Location = new System.Drawing.Point(9, 139);
            this.inputfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputfile.Name = "inputfile";
            this.inputfile.Size = new System.Drawing.Size(722, 26);
            this.inputfile.TabIndex = 38;
            this.inputfile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputlabel
            // 
            this.inputlabel.AutoSize = true;
            this.inputlabel.Location = new System.Drawing.Point(5, 114);
            this.inputlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputlabel.Name = "inputlabel";
            this.inputlabel.Size = new System.Drawing.Size(470, 20);
            this.inputlabel.TabIndex = 37;
            this.inputlabel.Text = "Select a Redux ROM with compatibility patch applied as the input.";
            this.inputlabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // CustomV11
            // 
            this.CustomV11.Location = new System.Drawing.Point(286, 8);
            this.CustomV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomV11.Name = "CustomV11";
            this.CustomV11.Size = new System.Drawing.Size(132, 35);
            this.CustomV11.TabIndex = 36;
            this.CustomV11.Text = "Customize...";
            this.toolTip1.SetToolTip(this.CustomV11, "Select difficulty first to start with a template.");
            this.CustomV11.UseVisualStyleBackColor = true;
            this.CustomV11.Click += new System.EventHandler(this.CustomV11_Click);
            // 
            // randomSpoiler
            // 
            this.randomSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.randomSpoiler.Location = new System.Drawing.Point(12, 485);
            this.randomSpoiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randomSpoiler.Name = "randomSpoiler";
            this.randomSpoiler.Size = new System.Drawing.Size(150, 35);
            this.randomSpoiler.TabIndex = 35;
            this.randomSpoiler.Text = "Random Spoiler";
            this.randomSpoiler.UseVisualStyleBackColor = true;
            this.randomSpoiler.Click += new System.EventHandler(this.randomSpoiler_Click);
            // 
            // createSpoilerLog
            // 
            this.createSpoilerLog.AutoSize = true;
            this.createSpoilerLog.Location = new System.Drawing.Point(610, 0);
            this.createSpoilerLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createSpoilerLog.Name = "createSpoilerLog";
            this.createSpoilerLog.Size = new System.Drawing.Size(167, 24);
            this.createSpoilerLog.TabIndex = 21;
            this.createSpoilerLog.Text = "Create Spoiler Log";
            this.createSpoilerLog.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Difficulty:";
            // 
            // randomizerDifficulty
            // 
            this.randomizerDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randomizerDifficulty.FormattingEnabled = true;
            this.randomizerDifficulty.Items.AddRange(new object[] {
            "Casual",
            "Speedrunner",
            "Masochist",
            "Custom"});
            this.randomizerDifficulty.Location = new System.Drawing.Point(96, 9);
            this.randomizerDifficulty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randomizerDifficulty.Name = "randomizerDifficulty";
            this.randomizerDifficulty.Size = new System.Drawing.Size(180, 28);
            this.randomizerDifficulty.TabIndex = 19;
            // 
            // controlsV11
            // 
            this.controlsV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsV11.Location = new System.Drawing.Point(546, 26);
            this.controlsV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlsV11.Name = "controlsV11";
            this.controlsV11.Size = new System.Drawing.Size(112, 35);
            this.controlsV11.TabIndex = 18;
            this.controlsV11.Text = "Controls";
            this.controlsV11.UseVisualStyleBackColor = true;
            this.controlsV11.Click += new System.EventHandler(this.controlsV11_Click);
            // 
            // browseV11
            // 
            this.browseV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseV11.Image = global::SuperMetroidRandomizer.Properties.Resources.MenuFileSaveIcon;
            this.browseV11.Location = new System.Drawing.Point(740, 207);
            this.browseV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseV11.Name = "browseV11";
            this.browseV11.Size = new System.Drawing.Size(38, 38);
            this.browseV11.TabIndex = 15;
            this.browseV11.UseVisualStyleBackColor = true;
            this.browseV11.Click += new System.EventHandler(this.browseV11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Seed (leave blank to generate new random ROM)";
            // 
            // outputV11
            // 
            this.outputV11.AcceptsReturn = true;
            this.outputV11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputV11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputV11.Location = new System.Drawing.Point(9, 249);
            this.outputV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputV11.Multiline = true;
            this.outputV11.Name = "outputV11";
            this.outputV11.ReadOnly = true;
            this.outputV11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputV11.Size = new System.Drawing.Size(769, 224);
            this.outputV11.TabIndex = 10;
            // 
            // seedV11
            // 
            this.seedV11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seedV11.Location = new System.Drawing.Point(9, 71);
            this.seedV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seedV11.Name = "seedV11";
            this.seedV11.Size = new System.Drawing.Size(769, 26);
            this.seedV11.TabIndex = 16;
            // 
            // createV11
            // 
            this.createV11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createV11.Location = new System.Drawing.Point(668, 26);
            this.createV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createV11.Name = "createV11";
            this.createV11.Size = new System.Drawing.Size(112, 35);
            this.createV11.TabIndex = 11;
            this.createV11.Text = "Create";
            this.createV11.UseVisualStyleBackColor = true;
            this.createV11.Click += new System.EventHandler(this.createV11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output Filename (<seed> is replaced with file seed, <date> is replaced with date)" +
    "";
            // 
            // filenameV11
            // 
            this.filenameV11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameV11.Location = new System.Drawing.Point(9, 213);
            this.filenameV11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filenameV11.Name = "filenameV11";
            this.filenameV11.Size = new System.Drawing.Size(722, 26);
            this.filenameV11.TabIndex = 14;
            this.filenameV11.Text = "SM Random <seed>.sfc";
            this.filenameV11.TextChanged += new System.EventHandler(this.filenameV11_TextChanged);
            this.filenameV11.Leave += new System.EventHandler(this.filename_Leave);
            // 
            // controls
            // 
            this.controls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controls.Location = new System.Drawing.Point(546, 12);
            this.controls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(112, 35);
            this.controls.TabIndex = 19;
            this.controls.Text = "Controls";
            this.controls.UseVisualStyleBackColor = true;
            this.controls.Click += new System.EventHandler(this.controls_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Image = global::SuperMetroidRandomizer.Properties.Resources.MenuFileSaveIcon;
            this.save.Location = new System.Drawing.Point(742, 112);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(38, 38);
            this.save.TabIndex = 7;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 575);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Super Metroid Randomizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton suitlessForced;
        private System.Windows.Forms.RadioButton suitlessPossible;
        private System.Windows.Forms.RadioButton suitlessDisabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputFilename;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
       // private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseV11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputV11;
        private System.Windows.Forms.TextBox seedV11;
        private System.Windows.Forms.Button createV11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filenameV11;
        private System.Windows.Forms.Button controlsV11;
        private System.Windows.Forms.Button controls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox randomizerDifficulty;
        private System.Windows.Forms.CheckBox createSpoilerLog;
        private System.Windows.Forms.Button randomSpoiler;
        private System.Windows.Forms.Button CustomV11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button inputselect;
        private System.Windows.Forms.TextBox inputfile;
        private System.Windows.Forms.Label inputlabel;
    }
}

