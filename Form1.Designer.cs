namespace Practico5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.app1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.app1ToolStripMenuItem,
            this.app2ToolStripMenuItem,
            this.aooToolStripMenuItem,
            this.app4ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // app1ToolStripMenuItem
            // 
            this.app1ToolStripMenuItem.Name = "app1ToolStripMenuItem";
            this.app1ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.app1ToolStripMenuItem.Text = "App1";
            this.app1ToolStripMenuItem.Click += new System.EventHandler(this.app1ToolStripMenuItem_Click);
            // 
            // app2ToolStripMenuItem
            // 
            this.app2ToolStripMenuItem.Name = "app2ToolStripMenuItem";
            this.app2ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.app2ToolStripMenuItem.Text = "App2";
            this.app2ToolStripMenuItem.Click += new System.EventHandler(this.app2ToolStripMenuItem_Click);
            // 
            // aooToolStripMenuItem
            // 
            this.aooToolStripMenuItem.Name = "aooToolStripMenuItem";
            this.aooToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aooToolStripMenuItem.Text = "App3";
            this.aooToolStripMenuItem.Click += new System.EventHandler(this.aooToolStripMenuItem_Click);
            // 
            // app4ToolStripMenuItem
            // 
            this.app4ToolStripMenuItem.Name = "app4ToolStripMenuItem";
            this.app4ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.app4ToolStripMenuItem.Text = "App4";
            this.app4ToolStripMenuItem.Click += new System.EventHandler(this.app4ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(665, 287);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem app1ToolStripMenuItem;
        private ToolStripMenuItem app2ToolStripMenuItem;
        private ToolStripMenuItem aooToolStripMenuItem;
        private ToolStripMenuItem app4ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}