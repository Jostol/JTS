namespace DooMDemoPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_play = new System.Windows.Forms.Button();
            this.textbox_commands = new System.Windows.Forms.TextBox();
            this.button_browse_executable = new System.Windows.Forms.Button();
            this.button_browse_pwads = new System.Windows.Forms.Button();
            this.textbox_port_path = new System.Windows.Forms.TextBox();
            this.button_select_demo = new System.Windows.Forms.Button();
            this.textbox_demo_path = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_refresh = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textbox_pwads = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(483, 397);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(130, 33);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "Play Demo";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // textbox_commands
            // 
            this.textbox_commands.Location = new System.Drawing.Point(11, 397);
            this.textbox_commands.Multiline = true;
            this.textbox_commands.Name = "textbox_commands";
            this.textbox_commands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_commands.Size = new System.Drawing.Size(443, 33);
            this.textbox_commands.TabIndex = 1;
            // 
            // button_browse_executable
            // 
            this.button_browse_executable.Location = new System.Drawing.Point(483, 33);
            this.button_browse_executable.Name = "button_browse_executable";
            this.button_browse_executable.Size = new System.Drawing.Size(130, 33);
            this.button_browse_executable.TabIndex = 2;
            this.button_browse_executable.Text = "DooM Port";
            this.button_browse_executable.UseVisualStyleBackColor = true;
            this.button_browse_executable.Click += new System.EventHandler(this.button_browse_executable_Click);
            // 
            // button_browse_pwads
            // 
            this.button_browse_pwads.Location = new System.Drawing.Point(483, 72);
            this.button_browse_pwads.Name = "button_browse_pwads";
            this.button_browse_pwads.Size = new System.Drawing.Size(130, 33);
            this.button_browse_pwads.TabIndex = 3;
            this.button_browse_pwads.Text = "PWADS";
            this.button_browse_pwads.UseVisualStyleBackColor = true;
            this.button_browse_pwads.Click += new System.EventHandler(this.button_browse_pwads_Click);
            // 
            // textbox_port_path
            // 
            this.textbox_port_path.Location = new System.Drawing.Point(11, 33);
            this.textbox_port_path.Multiline = true;
            this.textbox_port_path.Name = "textbox_port_path";
            this.textbox_port_path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_port_path.Size = new System.Drawing.Size(443, 33);
            this.textbox_port_path.TabIndex = 4;
            // 
            // button_select_demo
            // 
            this.button_select_demo.Location = new System.Drawing.Point(483, 262);
            this.button_select_demo.Name = "button_select_demo";
            this.button_select_demo.Size = new System.Drawing.Size(130, 33);
            this.button_select_demo.TabIndex = 6;
            this.button_select_demo.Text = "Choose Demo";
            this.button_select_demo.UseVisualStyleBackColor = true;
            this.button_select_demo.Click += new System.EventHandler(this.button_select_demo_Click);
            // 
            // textbox_demo_path
            // 
            this.textbox_demo_path.Location = new System.Drawing.Point(11, 262);
            this.textbox_demo_path.Multiline = true;
            this.textbox_demo_path.Name = "textbox_demo_path";
            this.textbox_demo_path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_demo_path.Size = new System.Drawing.Size(443, 33);
            this.textbox_demo_path.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(483, 358);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(130, 33);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "Refresh Commands";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "DOOM.WAD",
            "DOOM2.WAD",
            "TNT.WAD",
            "PLUTONIA.WAD",
            "HERETIC.WAD",
            "HEXEN.WAD"});
            this.listBox1.Location = new System.Drawing.Point(11, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 82);
            this.listBox1.TabIndex = 10;
            // 
            // textbox_pwads
            // 
            this.textbox_pwads.Location = new System.Drawing.Point(11, 72);
            this.textbox_pwads.Multiline = true;
            this.textbox_pwads.Name = "textbox_pwads";
            this.textbox_pwads.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_pwads.Size = new System.Drawing.Size(443, 184);
            this.textbox_pwads.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.textbox_pwads);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textbox_demo_path);
            this.Controls.Add(this.button_select_demo);
            this.Controls.Add(this.textbox_port_path);
            this.Controls.Add(this.button_browse_pwads);
            this.Controls.Add(this.button_browse_executable);
            this.Controls.Add(this.textbox_commands);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DooM Demo Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.TextBox textbox_commands;
        private System.Windows.Forms.Button button_browse_executable;
        private System.Windows.Forms.Button button_browse_pwads;
        private System.Windows.Forms.TextBox textbox_port_path;
        private System.Windows.Forms.Button button_select_demo;
        private System.Windows.Forms.TextBox textbox_demo_path;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textbox_pwads;
    }
}

