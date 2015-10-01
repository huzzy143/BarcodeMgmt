namespace InterpathBarcodeDesigner
{
    partial class ElementCtrl
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
            this.groupBox_Element = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.button_Properties = new System.Windows.Forms.Button();
            this.groupBox_Element.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Element
            // 
            this.groupBox_Element.Controls.Add(this.splitContainer1);
            this.groupBox_Element.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Element.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Element.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.groupBox_Element.Name = "groupBox_Element";
            this.groupBox_Element.Padding = new System.Windows.Forms.Padding(8, 5, 8, 3);
            this.groupBox_Element.Size = new System.Drawing.Size(266, 50);
            this.groupBox_Element.TabIndex = 4;
            this.groupBox_Element.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(8, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Text);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_Properties);
            this.splitContainer1.Size = new System.Drawing.Size(250, 27);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox_Text
            // 
            this.textBox_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Text.Location = new System.Drawing.Point(0, 0);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(210, 22);
            this.textBox_Text.TabIndex = 0;
            this.textBox_Text.TextChanged += new System.EventHandler(this.textBox_Text_TextChanged);
            // 
            // button_Properties
            // 
            this.button_Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Properties.Font = new System.Drawing.Font("MS Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Properties.Location = new System.Drawing.Point(0, 0);
            this.button_Properties.Name = "button_Properties";
            this.button_Properties.Size = new System.Drawing.Size(36, 27);
            this.button_Properties.TabIndex = 0;
            this.button_Properties.Text = "...";
            this.button_Properties.UseVisualStyleBackColor = true;
            this.button_Properties.Click += new System.EventHandler(this.button_Properties_Click);
            // 
            // ElementCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Element);
            this.Name = "ElementCtrl";
            this.Size = new System.Drawing.Size(266, 50);
            this.groupBox_Element.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Element;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_Text;
        private System.Windows.Forms.Button button_Properties;
    }
}
