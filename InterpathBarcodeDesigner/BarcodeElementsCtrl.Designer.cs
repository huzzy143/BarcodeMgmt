namespace InterpathBarcodeDesigner
{
    partial class BarcodeElementsCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeElementsCtrl));
            this.panelCtrls = new System.Windows.Forms.Panel();
            this.button_FromJSON = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.elementCtrl_Barcode = new InterpathBarcodeDesigner.ElementCtrl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_JSON = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button_ReloadFromDB = new System.Windows.Forms.Button();
            this.button_SaveToDB = new System.Windows.Forms.Button();
            this.button_SaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_AddNewElement = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCtrls
            // 
            this.panelCtrls.AutoScroll = true;
            this.panelCtrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrls.Location = new System.Drawing.Point(0, 78);
            this.panelCtrls.Name = "panelCtrls";
            this.panelCtrls.Size = new System.Drawing.Size(274, 178);
            this.panelCtrls.TabIndex = 0;
            // 
            // button_FromJSON
            // 
            this.button_FromJSON.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_FromJSON.Font = new System.Drawing.Font("MS Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FromJSON.Location = new System.Drawing.Point(0, 0);
            this.button_FromJSON.Name = "button_FromJSON";
            this.button_FromJSON.Size = new System.Drawing.Size(274, 28);
            this.button_FromJSON.TabIndex = 2;
            this.button_FromJSON.Text = "^ Load From JSON ^ ";
            this.button_FromJSON.UseVisualStyleBackColor = true;
            this.button_FromJSON.Click += new System.EventHandler(this.button_FromJSON_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelCtrls);
            this.splitContainer1.Panel1.Controls.Add(this.button_AddNewElement);
            this.splitContainer1.Panel1.Controls.Add(this.elementCtrl_Barcode);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.button_FromJSON);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(274, 444);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 3;
            // 
            // elementCtrl_Barcode
            // 
            this.elementCtrl_Barcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementCtrl_Barcode.Element = ((PR.Barcodes.BarcodeLabelElement)(resources.GetObject("elementCtrl_Barcode.Element")));
            this.elementCtrl_Barcode.ElementName = " [12]";
            this.elementCtrl_Barcode.ElementText = "000000000000";
            this.elementCtrl_Barcode.Location = new System.Drawing.Point(0, 0);
            this.elementCtrl_Barcode.Name = "elementCtrl_Barcode";
            this.elementCtrl_Barcode.Size = new System.Drawing.Size(274, 50);
            this.elementCtrl_Barcode.TabIndex = 1;
            this.elementCtrl_Barcode.OnChanged += new System.EventHandler(this.elementCtrl_Barcode_OnChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 28);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_JSON);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(274, 150);
            this.splitContainer2.SplitterDistance = 114;
            this.splitContainer2.TabIndex = 4;
            // 
            // txt_JSON
            // 
            this.txt_JSON.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_JSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_JSON.Location = new System.Drawing.Point(0, 0);
            this.txt_JSON.Name = "txt_JSON";
            this.txt_JSON.Size = new System.Drawing.Size(274, 114);
            this.txt_JSON.TabIndex = 3;
            this.txt_JSON.Text = "";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button_SaveAs);
            this.splitContainer3.Size = new System.Drawing.Size(274, 32);
            this.splitContainer3.SplitterDistance = 172;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.button_ReloadFromDB);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button_SaveToDB);
            this.splitContainer4.Size = new System.Drawing.Size(172, 32);
            this.splitContainer4.SplitterDistance = 85;
            this.splitContainer4.TabIndex = 0;
            // 
            // button_ReloadFromDB
            // 
            this.button_ReloadFromDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ReloadFromDB.Location = new System.Drawing.Point(0, 0);
            this.button_ReloadFromDB.Name = "button_ReloadFromDB";
            this.button_ReloadFromDB.Size = new System.Drawing.Size(85, 32);
            this.button_ReloadFromDB.TabIndex = 0;
            this.button_ReloadFromDB.Text = "Reload";
            this.button_ReloadFromDB.UseVisualStyleBackColor = true;
            this.button_ReloadFromDB.Click += new System.EventHandler(this.button_ReloadFromDB_Click);
            // 
            // button_SaveToDB
            // 
            this.button_SaveToDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveToDB.Location = new System.Drawing.Point(0, 0);
            this.button_SaveToDB.Name = "button_SaveToDB";
            this.button_SaveToDB.Size = new System.Drawing.Size(83, 32);
            this.button_SaveToDB.TabIndex = 0;
            this.button_SaveToDB.Text = "Save";
            this.button_SaveToDB.UseVisualStyleBackColor = true;
            this.button_SaveToDB.Click += new System.EventHandler(this.button_SaveToDB_Click);
            // 
            // button_SaveAs
            // 
            this.button_SaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveAs.Location = new System.Drawing.Point(0, 0);
            this.button_SaveAs.Name = "button_SaveAs";
            this.button_SaveAs.Size = new System.Drawing.Size(98, 32);
            this.button_SaveAs.TabIndex = 0;
            this.button_SaveAs.Text = "Save As...";
            this.button_SaveAs.UseVisualStyleBackColor = true;
            this.button_SaveAs.Click += new System.EventHandler(this.button_SaveAs_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON (.json)|*.json|TXT (.txt)|*.txt";
            this.saveFileDialog.Title = "Save Barcode Label Definition to file...";
            // 
            // button_AddNewElement
            // 
            this.button_AddNewElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddNewElement.Font = new System.Drawing.Font("MS Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewElement.Location = new System.Drawing.Point(0, 50);
            this.button_AddNewElement.Name = "button_AddNewElement";
            this.button_AddNewElement.Size = new System.Drawing.Size(274, 28);
            this.button_AddNewElement.TabIndex = 3;
            this.button_AddNewElement.Text = "Add New Element... ";
            this.button_AddNewElement.UseVisualStyleBackColor = true;
            this.button_AddNewElement.Click += new System.EventHandler(this.button_AddNewElement_Click);
            // 
            // BarcodeElementsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "BarcodeElementsCtrl";
            this.Size = new System.Drawing.Size(274, 444);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCtrls;
        private System.Windows.Forms.Button button_FromJSON;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ElementCtrl elementCtrl_Barcode;
        private System.Windows.Forms.RichTextBox txt_JSON;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button button_ReloadFromDB;
        private System.Windows.Forms.Button button_SaveToDB;
        private System.Windows.Forms.Button button_SaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button_AddNewElement;
    }
}
