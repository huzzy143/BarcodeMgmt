namespace InterpathBarcodeDesigner
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
            this.tabControl_Labels = new System.Windows.Forms.TabControl();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Labels
            // 
            this.tabControl_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Labels.Location = new System.Drawing.Point(10, 31);
            this.tabControl_Labels.Name = "tabControl_Labels";
            this.tabControl_Labels.SelectedIndex = 0;
            this.tabControl_Labels.Size = new System.Drawing.Size(754, 526);
            this.tabControl_Labels.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File});
            this.menuStrip1.Location = new System.Drawing.Point(10, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_New,
            this.toolStripSeparator2,
            this.menu_File_Connect,
            this.toolStripSeparator1,
            this.menu_File_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(44, 24);
            this.menu_File.Text = "&File";
            // 
            // menu_File_Exit
            // 
            this.menu_File_Exit.Name = "menu_File_Exit";
            this.menu_File_Exit.Size = new System.Drawing.Size(152, 24);
            this.menu_File_Exit.Text = "E&xit";
            this.menu_File_Exit.Click += new System.EventHandler(this.menu_File_Exit_Click);
            // 
            // menu_File_Connect
            // 
            this.menu_File_Connect.Name = "menu_File_Connect";
            this.menu_File_Connect.Size = new System.Drawing.Size(152, 24);
            this.menu_File_Connect.Text = "Connect...";
            this.menu_File_Connect.Click += new System.EventHandler(this.menu_File_Connect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(10, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(99, 20);
            this.statusLabel.Text = "Disconnected";
            // 
            // menu_File_New
            // 
            this.menu_File_New.Name = "menu_File_New";
            this.menu_File_New.Size = new System.Drawing.Size(152, 24);
            this.menu_File_New.Text = "New...";
            this.menu_File_New.Click += new System.EventHandler(this.menu_File_New_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 592);
            this.Controls.Add(this.tabControl_Labels);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpath Barcode Designer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Labels;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem menu_File_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

    }
}

