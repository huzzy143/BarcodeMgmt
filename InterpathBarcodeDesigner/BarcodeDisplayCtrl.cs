using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using PR.Barcodes;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace InterpathBarcodeDesigner
{
    public partial class BarcodeDisplayCtrl : UserControl
    {
        private PrintDocument _printDoc;

        private BarcodeLabel _label;
        public BarcodeLabel Label
        {
            get { return _label; }
            set
            {
                _label = value;
                if (_label != null)
                {
                    GenerateBarcodeLabelImage(checkBox_PreviewMode.Checked);
                }
            }
        }

        public Image BarcodeImage
        {
            get { return groupBox_Barcode.BackgroundImage; }
            set { groupBox_Barcode.BackgroundImage = value; }
        }

        public BarcodeDisplayCtrl()
        {
            InitializeComponent();

            _label = new BarcodeLabel();

            _printDoc = new PrintDocument();
            _printDoc.DefaultPageSettings = new PageSettings { Landscape = true };
            _printDoc.PrintPage += _printDoc_PrintPage;
        }

        private void GenerateBarcodeLabelImage(bool previewMode)
        {
            try
            {
                groupBox_Barcode.BackgroundImage = Label.GenerateLabel(previewMode);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void _printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(groupBox_Barcode.BackgroundImage, Point.Empty);
        }

        private void button_PrintLabel_Click(object sender, EventArgs e)
        {
            using (PrintDialog dialog = new PrintDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _printDoc.PrinterSettings = dialog.PrinterSettings;
                    _printDoc.Print();
                }
            }
        }

        private void button_SaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //groupBox_Barcode.BackgroundImage.Save(saveFileDialog.FileName);

                int width = 300;
                int height = 100;

                Graphics offScreenBufferGraphics;
                Metafile m;
                using (MemoryStream stream = new MemoryStream())
                {
                    using (offScreenBufferGraphics = Graphics.FromHwndInternal(IntPtr.Zero))
                    {
                        IntPtr deviceContextHandle = offScreenBufferGraphics.GetHdc();
                        m = new Metafile(
                        stream,
                        deviceContextHandle,
                        new RectangleF(0, 0, width, height),
                        MetafileFrameUnit.Pixel,
                        EmfType.EmfPlusOnly);
                        offScreenBufferGraphics.ReleaseHdc();
                    }
                }

                int pos = 0;
                string encodedValue =
                "1001011011010101001101101011011001010101101001011010101001101101010100110110101010011011010110110010101011010011010101011001101010101100101011011010010101101011001101010100101101101";
                int barWidth = width / encodedValue.Length;
                int shiftAdjustment = (width % encodedValue.Length) / 2;
                int barWidthModifier = 1;

                using (Graphics g = Graphics.FromImage(m))
                {
                    // Set everything to high quality
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;

                    MetafileHeader metafileHeader = m.GetMetafileHeader();
                    g.ScaleTransform(
                      metafileHeader.DpiX / g.DpiX,
                      metafileHeader.DpiY / g.DpiY);

                    g.PageUnit = GraphicsUnit.Pixel;
                    g.SetClip(new RectangleF(0, 0, width, height));

                    // clears the image and colors the entire background
                    g.Clear(Color.White);

                    // lines are barWidth wide so draw the appropriate color line vertically
                    using (Pen pen = new Pen(Color.Black, (float)barWidth / barWidthModifier))
                    {
                        while (pos < encodedValue.Length)
                        {
                            if (encodedValue[pos] == '1')
                            {
                                g.DrawLine(
                                pen,
                                new Point(pos * barWidth + shiftAdjustment + 1, 0),
                                new Point(pos * barWidth + shiftAdjustment + 1, height));
                            }

                            pos++;
                        } // while
                    } // using
                } // using

                // Get a handle to the metafile
                IntPtr iptrMetafileHandle = m.GetHenhmetafile();

                // Export metafile to an image file
                CopyEnhMetaFile(iptrMetafileHandle, saveFileDialog.FileName);

                // Delete the metafile from memory
                DeleteEnhMetaFile(iptrMetafileHandle);
            }
        }

        [DllImport("gdi32.dll")]
        static extern IntPtr CopyEnhMetaFile(  // Copy EMF to file
          IntPtr hemfSrc,   // Handle to EMF
          String lpszFile // File
        );

        [DllImport("gdi32.dll")]
        static extern int DeleteEnhMetaFile(  // Delete EMF
          IntPtr hemf // Handle to EMF
        );

        private void checkBox_PreviewMode_CheckedChanged(object sender, EventArgs e)
        {
            GenerateBarcodeLabelImage(checkBox_PreviewMode.Checked);
        }
    }
}
