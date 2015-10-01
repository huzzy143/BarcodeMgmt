namespace InterpathBarcodeDesigner
{
    partial class DBConnWin
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Password = new System.Windows.Forms.GroupBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.groupBox_User = new System.Windows.Forms.GroupBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.groupBox_Server = new System.Windows.Forms.GroupBox();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox_Database = new System.Windows.Forms.GroupBox();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Password.SuspendLayout();
            this.groupBox_User.SuspendLayout();
            this.groupBox_Server.SuspendLayout();
            this.groupBox_Database.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Password);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_User);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Database);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Server);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxRemember);
            this.splitContainer1.Panel2.Controls.Add(this.button_Cancel);
            this.splitContainer1.Panel2.Controls.Add(this.button_Connect);
            this.splitContainer1.Size = new System.Drawing.Size(378, 340);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Password
            // 
            this.groupBox_Password.Controls.Add(this.textBox_Password);
            this.groupBox_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Password.Location = new System.Drawing.Point(10, 205);
            this.groupBox_Password.Name = "groupBox_Password";
            this.groupBox_Password.Padding = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.groupBox_Password.Size = new System.Drawing.Size(358, 65);
            this.groupBox_Password.TabIndex = 2;
            this.groupBox_Password.TabStop = false;
            this.groupBox_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(8, 23);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(342, 28);
            this.textBox_Password.TabIndex = 0;
            // 
            // groupBox_User
            // 
            this.groupBox_User.Controls.Add(this.textBox_Username);
            this.groupBox_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_User.Location = new System.Drawing.Point(10, 140);
            this.groupBox_User.Name = "groupBox_User";
            this.groupBox_User.Padding = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.groupBox_User.Size = new System.Drawing.Size(358, 65);
            this.groupBox_User.TabIndex = 1;
            this.groupBox_User.TabStop = false;
            this.groupBox_User.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(8, 23);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(342, 28);
            this.textBox_Username.TabIndex = 0;
            // 
            // groupBox_Server
            // 
            this.groupBox_Server.Controls.Add(this.textBox_Server);
            this.groupBox_Server.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Server.Location = new System.Drawing.Point(10, 10);
            this.groupBox_Server.Name = "groupBox_Server";
            this.groupBox_Server.Padding = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.groupBox_Server.Size = new System.Drawing.Size(358, 65);
            this.groupBox_Server.TabIndex = 0;
            this.groupBox_Server.TabStop = false;
            this.groupBox_Server.Text = "Server";
            // 
            // textBox_Server
            // 
            this.textBox_Server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Server.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Server.Location = new System.Drawing.Point(8, 23);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(342, 28);
            this.textBox_Server.TabIndex = 0;
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Location = new System.Drawing.Point(18, 19);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(99, 21);
            this.checkBoxRemember.TabIndex = 2;
            this.checkBoxRemember.Text = "Remember";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            this.checkBoxRemember.CheckedChanged += new System.EventHandler(this.checkBoxRemember_CheckedChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(147, 8);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(116, 41);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(269, 8);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(97, 41);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox_Database
            // 
            this.groupBox_Database.Controls.Add(this.textBox_Database);
            this.groupBox_Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Database.Location = new System.Drawing.Point(10, 75);
            this.groupBox_Database.Name = "groupBox_Database";
            this.groupBox_Database.Padding = new System.Windows.Forms.Padding(8, 8, 8, 3);
            this.groupBox_Database.Size = new System.Drawing.Size(358, 65);
            this.groupBox_Database.TabIndex = 3;
            this.groupBox_Database.TabStop = false;
            this.groupBox_Database.Text = "Database";
            // 
            // textBox_Database
            // 
            this.textBox_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Database.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Database.Location = new System.Drawing.Point(8, 23);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(342, 28);
            this.textBox_Database.TabIndex = 0;
            // 
            // DBConnWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 340);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DBConnWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Connection...";
            this.TopMost = true;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Password.ResumeLayout(false);
            this.groupBox_Password.PerformLayout();
            this.groupBox_User.ResumeLayout(false);
            this.groupBox_User.PerformLayout();
            this.groupBox_Server.ResumeLayout(false);
            this.groupBox_Server.PerformLayout();
            this.groupBox_Database.ResumeLayout(false);
            this.groupBox_Database.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupBox_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.GroupBox groupBox_User;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.GroupBox groupBox_Server;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.GroupBox groupBox_Database;
        private System.Windows.Forms.TextBox textBox_Database;
    }
}