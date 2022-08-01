namespace Task_Grabber
{
    partial class Task_Grabber
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
            this.textScripts = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Clear_Scripts = new System.Windows.Forms.Button();
            this.Load_Profile = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.ComboBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Find_Element = new System.Windows.Forms.Button();
            this.Click_Element = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.TextBox();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.TextBox();
            this.Panel_Custom = new System.Windows.Forms.Panel();
            this.Win_Index = new System.Windows.Forms.TextBox();
            this.WinCheck = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.Button();
            this.Sound = new System.Windows.Forms.Button();
            this.Xpand = new System.Windows.Forms.Button();
            this.RefreshX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.count_down = new System.Windows.Forms.TextBox();
            this.Always_Top = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel_Body.SuspendLayout();
            this.Panel_Custom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textScripts
            // 
            this.textScripts.AllowDrop = true;
            this.textScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textScripts.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textScripts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textScripts.Location = new System.Drawing.Point(7, 54);
            this.textScripts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.textScripts.Multiline = true;
            this.textScripts.Name = "textScripts";
            this.textScripts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textScripts.Size = new System.Drawing.Size(339, 76);
            this.textScripts.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Start.Location = new System.Drawing.Point(269, 27);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(77, 25);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear_Scripts
            // 
            this.Clear_Scripts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Clear_Scripts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clear_Scripts.Location = new System.Drawing.Point(293, 27);
            this.Clear_Scripts.Margin = new System.Windows.Forms.Padding(1);
            this.Clear_Scripts.Name = "Clear_Scripts";
            this.Clear_Scripts.Size = new System.Drawing.Size(45, 23);
            this.Clear_Scripts.TabIndex = 4;
            this.Clear_Scripts.Text = "Clear";
            this.Clear_Scripts.UseVisualStyleBackColor = false;
            this.Clear_Scripts.Click += new System.EventHandler(this.Clear_Scripts_Click);
            // 
            // Load_Profile
            // 
            this.Load_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Profile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Load_Profile.Location = new System.Drawing.Point(189, 27);
            this.Load_Profile.Name = "Load_Profile";
            this.Load_Profile.Size = new System.Drawing.Size(77, 25);
            this.Load_Profile.TabIndex = 9;
            this.Load_Profile.Text = "Load_Profile";
            this.Load_Profile.UseVisualStyleBackColor = false;
            this.Load_Profile.Click += new System.EventHandler(this.Load_Profile_Click);
            // 
            // Profile
            // 
            this.Profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profile.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Profile.FormattingEnabled = true;
            this.Profile.Location = new System.Drawing.Point(59, 29);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(128, 21);
            this.Profile.TabIndex = 10;
            this.Profile.SelectedIndexChanged += new System.EventHandler(this.Profile_SelectedIndexChanged);
            // 
            // Value
            // 
            this.Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Value.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(3, 27);
            this.Value.Margin = new System.Windows.Forms.Padding(1);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(200, 21);
            this.Value.TabIndex = 11;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // Find_Element
            // 
            this.Find_Element.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Find_Element.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Find_Element.Location = new System.Drawing.Point(205, 27);
            this.Find_Element.Margin = new System.Windows.Forms.Padding(1);
            this.Find_Element.Name = "Find_Element";
            this.Find_Element.Size = new System.Drawing.Size(45, 23);
            this.Find_Element.TabIndex = 12;
            this.Find_Element.Text = "Find";
            this.Find_Element.UseVisualStyleBackColor = false;
            this.Find_Element.Click += new System.EventHandler(this.Find_Element_Click);
            // 
            // Click_Element
            // 
            this.Click_Element.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Click_Element.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Click_Element.Location = new System.Drawing.Point(250, 27);
            this.Click_Element.Margin = new System.Windows.Forms.Padding(1);
            this.Click_Element.Name = "Click_Element";
            this.Click_Element.Size = new System.Drawing.Size(45, 23);
            this.Click_Element.TabIndex = 13;
            this.Click_Element.Text = "Click";
            this.Click_Element.UseVisualStyleBackColor = false;
            this.Click_Element.Click += new System.EventHandler(this.Click_Element_Click);
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(102, 3);
            this.Timer.Multiline = true;
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(40, 20);
            this.Timer.TabIndex = 14;
            this.Timer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Timer_KeyDown);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_Body.Controls.Add(this.label1);
            this.panel_Body.Controls.Add(this.Version);
            this.panel_Body.Controls.Add(this.Head);
            this.panel_Body.Controls.Add(this.Panel_Custom);
            this.panel_Body.Controls.Add(this.textScripts);
            this.panel_Body.Controls.Add(this.Xpand);
            this.panel_Body.Controls.Add(this.RefreshX);
            this.panel_Body.Controls.Add(this.label4);
            this.panel_Body.Controls.Add(this.count_down);
            this.panel_Body.Controls.Add(this.Always_Top);
            this.panel_Body.Controls.Add(this.Minimize);
            this.panel_Body.Controls.Add(this.Exit);
            this.panel_Body.Controls.Add(this.Timer);
            this.panel_Body.Controls.Add(this.Start);
            this.panel_Body.Controls.Add(this.Profile);
            this.panel_Body.Controls.Add(this.Load_Profile);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(353, 229);
            this.panel_Body.TabIndex = 15;
            this.panel_Body.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Body_MouseDown);
            this.panel_Body.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Body_MouseMove);
            this.panel_Body.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Body_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "V";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.Color.Snow;
            this.Version.Location = new System.Drawing.Point(25, 7);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(22, 13);
            this.Version.TabIndex = 29;
            this.Version.Text = "3.3";
            // 
            // Head
            // 
            this.Head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Head.BackColor = System.Drawing.Color.DarkCyan;
            this.Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.Location = new System.Drawing.Point(150, 3);
            this.Head.MaximumSize = new System.Drawing.Size(130, 20);
            this.Head.Multiline = true;
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(10, 20);
            this.Head.TabIndex = 28;
            this.Head.Text = "Normal_Mode";
            // 
            // Panel_Custom
            // 
            this.Panel_Custom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Custom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel_Custom.Controls.Add(this.Win_Index);
            this.Panel_Custom.Controls.Add(this.WinCheck);
            this.Panel_Custom.Controls.Add(this.Console);
            this.Panel_Custom.Controls.Add(this.Help);
            this.Panel_Custom.Controls.Add(this.Sound);
            this.Panel_Custom.Controls.Add(this.Click_Element);
            this.Panel_Custom.Controls.Add(this.Find_Element);
            this.Panel_Custom.Controls.Add(this.Value);
            this.Panel_Custom.Controls.Add(this.Clear_Scripts);
            this.Panel_Custom.Location = new System.Drawing.Point(7, 138);
            this.Panel_Custom.Name = "Panel_Custom";
            this.Panel_Custom.Size = new System.Drawing.Size(339, 76);
            this.Panel_Custom.TabIndex = 27;
            // 
            // Win_Index
            // 
            this.Win_Index.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Win_Index.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Win_Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win_Index.Location = new System.Drawing.Point(205, 50);
            this.Win_Index.Multiline = true;
            this.Win_Index.Name = "Win_Index";
            this.Win_Index.Size = new System.Drawing.Size(61, 23);
            this.Win_Index.TabIndex = 28;
            this.Win_Index.Text = "0";
            this.Win_Index.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Win_Index_KeyDown);
            // 
            // WinCheck
            // 
            this.WinCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WinCheck.BackColor = System.Drawing.Color.PaleTurquoise;
            this.WinCheck.Location = new System.Drawing.Point(271, 50);
            this.WinCheck.Name = "WinCheck";
            this.WinCheck.Size = new System.Drawing.Size(67, 25);
            this.WinCheck.TabIndex = 28;
            this.WinCheck.Text = "WinCheck";
            this.WinCheck.UseVisualStyleBackColor = false;
            this.WinCheck.Click += new System.EventHandler(this.WinCheck_Click);
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.AutoCompleteCustomSource.AddRange(new string[] {
            "Show Status",
            "Show Configs",
            "Set Q",
            "Set Sound",
            "Set Profile",
            "Show Xpaths",
            "Config_Editor",
            "Stop",
            "Values",
            "Headless_ON",
            "Headless_OFF",
            "Goto_Dash",
            "Backup_Config"});
            this.Console.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Console.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Console.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Console.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Console.Location = new System.Drawing.Point(3, 3);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(333, 20);
            this.Console.TabIndex = 26;
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            // 
            // Help
            // 
            this.Help.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Help.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Help.Location = new System.Drawing.Point(0, 50);
            this.Help.Margin = new System.Windows.Forms.Padding(1);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(46, 25);
            this.Help.TabIndex = 25;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Sound
            // 
            this.Sound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Sound.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Sound.Location = new System.Drawing.Point(48, 50);
            this.Sound.Margin = new System.Windows.Forms.Padding(1);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(46, 25);
            this.Sound.TabIndex = 24;
            this.Sound.Text = "Sound";
            this.Sound.UseVisualStyleBackColor = false;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // Xpand
            // 
            this.Xpand.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Xpand.Location = new System.Drawing.Point(7, 29);
            this.Xpand.Name = "Xpand";
            this.Xpand.Size = new System.Drawing.Size(46, 23);
            this.Xpand.TabIndex = 22;
            this.Xpand.Text = "Xpand";
            this.Xpand.UseVisualStyleBackColor = false;
            this.Xpand.Click += new System.EventHandler(this.Expand_Click);
            // 
            // RefreshX
            // 
            this.RefreshX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshX.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RefreshX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshX.Location = new System.Drawing.Point(218, 3);
            this.RefreshX.Multiline = true;
            this.RefreshX.Name = "RefreshX";
            this.RefreshX.Size = new System.Drawing.Size(55, 19);
            this.RefreshX.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Refresh:";
            // 
            // count_down
            // 
            this.count_down.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.count_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_down.Location = new System.Drawing.Point(55, 3);
            this.count_down.Multiline = true;
            this.count_down.Name = "count_down";
            this.count_down.Size = new System.Drawing.Size(40, 20);
            this.count_down.TabIndex = 19;
            // 
            // Always_Top
            // 
            this.Always_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Always_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Always_Top.ForeColor = System.Drawing.Color.Red;
            this.Always_Top.Location = new System.Drawing.Point(278, 0);
            this.Always_Top.Name = "Always_Top";
            this.Always_Top.Size = new System.Drawing.Size(25, 22);
            this.Always_Top.TabIndex = 17;
            this.Always_Top.Text = "T";
            this.Always_Top.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Always_Top.UseVisualStyleBackColor = true;
            this.Always_Top.Click += new System.EventHandler(this.Always_Top_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Red;
            this.Minimize.Location = new System.Drawing.Point(303, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(25, 22);
            this.Minimize.TabIndex = 16;
            this.Minimize.Text = "---";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(328, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 22);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Task_Grabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(353, 229);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "Task_Grabber";
            this.Text = "Task_Grabber";
            this.Load += new System.EventHandler(this.Task_Grabber_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.Panel_Custom.ResumeLayout(false);
            this.Panel_Custom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear_Scripts;
        private System.Windows.Forms.Button Load_Profile;
        private System.Windows.Forms.ComboBox Profile;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button Find_Element;
        private System.Windows.Forms.Button Click_Element;
        private System.Windows.Forms.TextBox Timer;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button Always_Top;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox count_down;
        private System.Windows.Forms.TextBox RefreshX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Xpand;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Sound;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Panel Panel_Custom;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.TextBox textScripts;
        private System.Windows.Forms.Button WinCheck;
        private System.Windows.Forms.TextBox Win_Index;
        private System.Windows.Forms.TextBox Head;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label label1;
    }
}

