using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpathBarcodeDesigner
{
    public partial class ElementPropsWin : Form
    {
        public Rectangle ElemArea
        {
            get
            {
                return new Rectangle((int)numericUpDown_X.Value, (int)numericUpDown_Y.Value, (int)numericUpDown_Width.Value, (int)numericUpDown_Height.Value);
            }
            set
            {
                numericUpDown_X.Value = value.X;
                numericUpDown_Y.Value = value.Y;
                numericUpDown_Width.Value = value.Width;
                numericUpDown_Height.Value = value.Height;
            }
        }

        public string Title
        {
            get { return textBox_Title.Text.Trim(); }
            set { textBox_Title.Text = value; }
        }

        public string DefaultText
        {
            get { return textBox_DefaultText.Text.Trim(); }
            set { textBox_DefaultText.Text = value; }
        }

        public int Rotation
        {
            get { return (int) numericUpDown_Rotation.Value; }
            set { numericUpDown_Rotation.Value = value; }
        }

        public string FontName { get; set; }
        public float FontSize { get; set; }
        public FontStyle FontStyle { get; set; }
        public int ForecolorFromArgb { get; set; }

        public ElementPropsWin()
        {
            InitializeComponent();

            SetRotation(0);

            SetFont(SystemFonts.DefaultFont.Name, 6f, System.Drawing.FontStyle.Regular);

            SetColor(Color.Black.ToArgb());
        }

        public void SetRotation(int rotation)
        {
            numericUpDown_Rotation.Value = rotation;
        }

        public void SetFont(string name, float size, FontStyle fs)
        {
            FontName = name;
            FontSize = size;
            FontStyle = fs;

            using (Font font = new Font(name, size, fs))
            {
                textBox_Font.Font = font;
                textBox_Font.Text = font.ToString();
            }
        }

        public void SetColor(int colorFromArgb)
        {
            ForecolorFromArgb = colorFromArgb;
            textBox_Forecolor.ForeColor = Color.FromArgb(colorFromArgb);
            textBox_Forecolor.Text = textBox_Forecolor.ForeColor.ToString();
        }

        private void button_ColorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog { Color = Color.FromArgb(ForecolorFromArgb) })
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SetColor(dialog.Color.ToArgb());
                }
            }
        }

        private void button_FontPicker_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog { Font =  new Font(FontName, FontSize, FontStyle)})
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SetFont(dialog.Font.Name, dialog.Font.Size, dialog.Font.Style);
                }
            }
        }
    }
}
