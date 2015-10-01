namespace InterpathBarcodeDesigner
{
    partial class BarcodeDisplayCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Barcode = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBox_PreviewMode = new System.Windows.Forms.CheckBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button_PrintLabel = new System.Windows.Forms.Button();
            this.button_SaveAs = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Barcode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(512, 383);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Barcode
            // 
            this.groupBox_Barcode.BackColor = System.Drawing.Color.LightGray;
            this.groupBox_Barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox_Barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Barcode.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Barcode.Name = "groupBox_Barcode";
            this.groupBox_Barcode.Size = new System.Drawing.Size(512, 331);
            this.groupBox_Barcode.TabIndex = 1;
            this.groupBox_Barcode.TabStop = false;
            this.groupBox_Barcode.Text = "Collection Barcode";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.checkBox_PreviewMode);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(512, 48);
            this.splitContainer2.SplitterDistance = 148;
            this.splitContainer2.TabIndex = 7;
            // 
            // checkBox_PreviewMode
            // 
            this.checkBox_PreviewMode.AutoSize = true;
            this.checkBox_PreviewMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_PreviewMode.Location = new System.Drawing.Point(20, 0);
            this.checkBox_PreviewMode.Name = "checkBox_PreviewMode";
            this.checkBox_PreviewMode.Size = new System.Drawing.Size(128, 48);
            this.checkBox_PreviewMode.TabIndex = 6;
            this.checkBox_PreviewMode.Text = "Preview Mode";
            this.checkBox_PreviewMode.UseVisualStyleBackColor = true;
            this.checkBox_PreviewMode.CheckedChanged += new System.EventHandler(this.checkBox_PreviewMode_CheckedChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button_PrintLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button_SaveAs);
            this.splitContainer3.Size = new System.Drawing.Size(360, 48);
            this.splitContainer3.SplitterDistance = 173;
            this.splitContainer3.TabIndex = 0;
            // 
            // button_PrintLabel
            // 
            this.button_PrintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PrintLabel.Location = new System.Drawing.Point(0, 0);
            this.button_PrintLabel.Name = "button_PrintLabel";
            this.button_PrintLabel.Size = new System.Drawing.Size(173, 48);
            this.button_PrintLabel.TabIndex = 4;
            this.button_PrintLabel.Text = "Print";
            this.button_PrintLabel.UseVisualStyleBackColor = true;
            this.button_PrintLabel.Click += new System.EventHandler(this.button_PrintLabel_Click);
            // 
            // button_SaveAs
            // 
            this.button_SaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveAs.Location = new System.Drawing.Point(0, 0);
            this.button_SaveAs.Name = "button_SaveAs";
            this.button_SaveAs.Size = new System.Drawing.Size(183, 48);
            this.button_SaveAs.TabIndex = 5;
            this.button_SaveAs.Text = "Save As...";
            this.button_SaveAs.UseVisualStyleBackColor = true;
            this.button_SaveAs.Click += new System.EventHandler(this.button_SaveAs_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PNG|*.png|WMF|*.emf";
            // 
            // BarcodeDisplayCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "BarcodeDisplayCtrl";
            this.Size = new System.Drawing.Size(512, 383);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_Barcode;
        private System.Windows.Forms.Button button_SaveAs;
        private System.Windows.Forms.Button button_PrintLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox checkBox_PreviewMode;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}
