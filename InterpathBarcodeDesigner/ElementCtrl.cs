using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR.Barcodes;

namespace InterpathBarcodeDesigner
{
    public partial class ElementCtrl : UserControl
    {
        public event EventHandler OnChanged;

        public BarcodeLabelElement Element { get; set; }

        public string ElementName
        {
            get { return groupBox_Element.Text; }
            set { groupBox_Element.Text = value; }
        }

        public string ElementText
        {
            get { return textBox_Text.Text; }
            set { textBox_Text.Text = value; }
        }

        public ElementCtrl()
        {
            InitializeComponent();

            Element = new BarcodeLabelElement();
        }

        public ElementCtrl(BarcodeLabelElement element)
        {
            InitializeComponent();

            Element = element;

            ElementName = element.Title;

            ElementText = element.Text;
        }

        private void textBox_Text_TextChanged(object sender, EventArgs e)
        {
            ElementName = Element.Title;

            Element.Text = textBox_Text.Text.Trim();

            if (OnChanged != null) { OnChanged(this, EventArgs.Empty); }
        }

        private void button_Properties_Click(object sender, EventArgs e)
        {
            using (ElementPropsWin epropWin = new ElementPropsWin())
            {
                using (Font font = new Font(Element.FontName, Element.FontSize, Element.FontStyle))
                {
                    epropWin.Title = Element.Title;
                    epropWin.DefaultText = Element.Text;
                    epropWin.ElemArea = Element.Area;
                    epropWin.Rotation = Element.Rotation;
                    epropWin.FontName = font.Name;
                    epropWin.FontSize = font.Size;
                    epropWin.FontStyle = font.Style;
                    epropWin.ForecolorFromArgb = Element.Forecolor;
                }

                if (epropWin.ShowDialog() == DialogResult.OK)
                {
                    Element.Title = epropWin.Title;
                    Element.Text = epropWin.DefaultText;
                    Element.Area = epropWin.ElemArea;
                    Element.Rotation = epropWin.Rotation;
                    Element.FontName = epropWin.FontName;
                    Element.FontSize = epropWin.FontSize;
                    Element.FontStyle = epropWin.FontStyle;
                    Element.Forecolor = epropWin.ForecolorFromArgb;

                    if (OnChanged != null) { OnChanged(this, EventArgs.Empty); }
                }
            }
        }
    }
}