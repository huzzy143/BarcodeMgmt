using System;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using BL = BarcodeLib;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace PR.Barcodes
{
    [Serializable]
    public class BarcodeLabel
    {
        public static readonly Type _type;

        public Size Size { get; set; }

        public Barcode Barcode { get; set; }

        public List<BarcodeLabelElement> Elements { get; set; }

        static BarcodeLabel()
        {
            _type = typeof(BarcodeLabel);
        }

        public BarcodeLabel()
        {
            Barcode = new Barcode();
            Barcode.Title = "Barcode";
            this.Size = new Size(240, 120);
            Barcode.Area = new Rectangle((this.Size.Width / 2) - (Barcode.Area.Width / 2), (this.Size.Height / 2) - (Barcode.Area.Height / 2), Barcode.Area.Width, Barcode.Area.Height);
            Elements = new List<BarcodeLabelElement>(0);
        }

        public Image GenerateLabel(bool layoutMode = false)
        {
            Bitmap bmp = new Bitmap(Size.Width, Size.Height);

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(Color.White);
            }

            Image bcimg = GenerateBarcode(Barcode);

            bmp.SetResolution(bcimg.HorizontalResolution, bcimg.VerticalResolution);

            Image label = bmp;

            OverlayImage(ref label, bcimg, Barcode.Area, Barcode.Rotation);

            OverlayElements(ref label, layoutMode, Elements.ToArray());

            return bmp;
        }

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static void OverlayElements(ref Image img, bool layoutMode = false, params BarcodeLabelElement[] elements)
        {
            if (elements == null) { return; }

            for (int i = 0; i < elements.Length; i++)
            {
                using (Font font = new Font(elements[i].FontName, elements[i].FontSize, elements[i].FontStyle))
                {
                    OverlayText(ref img, layoutMode, elements[i].Text, font, new SolidBrush(Color.FromArgb(elements[i].Forecolor)), elements[i].Area, elements[i].Rotation);
                }
            }
        }

        public static Image GenerateBarcode(Barcode barcode)
        {
            using (BL.Barcode bc = new BL.Barcode())
            {
                using (Font font = new Font(barcode.FontName, barcode.FontSize, barcode.FontStyle))
                {
                    bc.Height = barcode.Area.Height;
                    bc.Width = barcode.Area.Width;
                    bc.ForeColor = Color.FromArgb(barcode.Forecolor);
                    bc.IncludeLabel = barcode.IncludeText;
                    bc.LabelPosition = ((BL.LabelPositions)barcode.TextOrientation);
                    bc.Alignment = ((BL.AlignmentPositions)barcode.Alignment);
                    bc.LabelFont = font;
                    return bc.Encode((BL.TYPE)barcode.Symbology, barcode.Text);
                }
            }
        }

        public static void OverlayImage(ref Image img, Image overlay, Rectangle area, int rotation = 0)
        {
            using (Graphics graphics = Graphics.FromImage(img))
            {
                if (rotation != 0)
                {
                    graphics.TranslateTransform(0, img.Height);
                    graphics.RotateTransform(rotation);
                }

                graphics.DrawImage(overlay, area);

                graphics.ResetTransform();
            }
        }

        private static void PeformTransforms(ref Graphics graphics, Size size, Rectangle area, int rotation = 0)
        {
            graphics.TranslateTransform((area.Height / 2) + area.X, ((rotation < 0) ? ((size.Height / 2) - area.Y) : ((size.Height / 2) + area.Y)));
            graphics.RotateTransform(rotation);
        }

        public static void OverlayText(ref Image img, bool layoutMode, string text, Font font, SolidBrush forecolor, Rectangle area, int rotation)
        {
            using (Graphics graphics = Graphics.FromImage(img))
            {
                if (rotation != 0)
                {
                    graphics.TranslateTransform(0, 0);
                    graphics.RotateTransform(rotation);

                    if (rotation < 0)
                    {
                        area.Y -= img.Height;
                    }

                    if (layoutMode)
                    {
                        graphics.FillRectangle(Brushes.Black, new Rectangle(area.Y, area.X, area.Width, area.Height));
                        graphics.DrawString(text, font, Brushes.White, area.Y, area.X, new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.NoClip));
                    }
                    else
                    {
                        graphics.DrawString(text, font, forecolor, (rotation < 0) ? area.Y : area.X, (rotation < 0) ? area.X : area.Y, new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.NoClip));
                    }
                }
                else
                {
                    if (layoutMode)
                    {
                        graphics.FillRectangle(Brushes.Black, area);
                        graphics.DrawString(text, font, Brushes.White, (RectangleF)area, new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.NoClip));
                    }
                    else
                    {
                        graphics.DrawString(text, font, forecolor, (RectangleF)area, new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.NoClip));
                    }
                }

                graphics.ResetTransform();
            }
        }
    }
}
