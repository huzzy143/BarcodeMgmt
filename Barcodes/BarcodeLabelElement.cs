using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PR.Barcodes
{
    [Serializable]
    public class BarcodeLabelElement
    {
        public static readonly RuntimeTypeHandle _handle;

        static BarcodeLabelElement()
        {
            _handle = typeof(BarcodeLabelElement).TypeHandle;
        }

        public string Title { get; set; }

        public string Text { get; set; }

        public Rectangle Area { get; set; }

        public string FontName { get; set; }

        public float FontSize { get; set; }

        public FontStyle FontStyle { get; set; }

        public int Rotation { get; set; }

        public int Forecolor { get; set; }

        public BarcodeLabelElement()
        {
            Title = string.Empty;
            Text = string.Empty;
            Area = new Rectangle(0, 0, 150, 40);
            Forecolor = Color.Black.ToArgb();
            FontName = SystemFonts.DefaultFont.Name;
            FontSize = 6f;
            FontStyle = System.Drawing.FontStyle.Regular;
            Rotation = 0;
        }
    }
}
