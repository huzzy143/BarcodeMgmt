using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR.Barcodes
{
    public enum Symbologies
    {
        UNSPECIFIED = 0,
        UPCA = 1,
        UPCE = 2,
        UPC_SUPPLEMENTAL_2DIGIT = 3,
        UPC_SUPPLEMENTAL_5DIGIT = 4,
        EAN13 = 5,
        EAN8 = 6,
        Interleaved2of5 = 7,
        Standard2of5 = 8,
        Industrial2of5 = 9,
        CODE39 = 10,
        CODE39Extended = 11,
        CODE39_Mod43 = 12,
        Codabar = 13,
        PostNet = 14,
        BOOKLAND = 15,
        ISBN = 16,
        JAN13 = 17,
        MSI_Mod10 = 18,
        MSI_2Mod10 = 19,
        MSI_Mod11 = 20,
        MSI_Mod11_Mod10 = 21,
        Modified_Plessey = 22,
        CODE11 = 23,
        USD8 = 24,
        UCC12 = 25,
        UCC13 = 26,
        LOGMARS = 27,
        CODE128 = 28,
        CODE128A = 29,
        CODE128B = 30,
        CODE128C = 31,
        ITF14 = 32,
        CODE93 = 33,
        TELEPEN = 34,
        FIM = 35,
        PHARMACODE = 36,
    }

    public enum LabelOrientation
    {
        TOPLEFT = 0,
        TOPCENTER = 1,
        TOPRIGHT = 2,
        BOTTOMLEFT = 3,
        BOTTOMCENTER = 4,
        BOTTOMRIGHT = 5,
    }

    public enum AlignmentPositions
    {
        CENTER = 0,
        LEFT = 1,
        RIGHT = 2,
    }

    [Serializable]
    public class Barcode : BarcodeLabelElement
    {
        public Symbologies Symbology { get; set; }

        public bool IncludeText { get; set; }

        public AlignmentPositions Alignment { get; set; }

        public LabelOrientation TextOrientation { get; set; }

        public Barcode()
        {
            Symbology = Symbologies.CODE128;
            IncludeText = true;
            Alignment = AlignmentPositions.CENTER;
            TextOrientation = LabelOrientation.BOTTOMCENTER;
            Text = "000000000000";
        }
    }
}
