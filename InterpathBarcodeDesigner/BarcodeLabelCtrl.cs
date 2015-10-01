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
using System.Reflection;

namespace InterpathBarcodeDesigner
{
    public partial class BarcodeLabelCtrl : UserControl
    {
        private BarcodeElementsCtrl ctrl_BarcodeElements;

        private BarcodeDisplayCtrl ctrl_BarcodeDisplay;

        private BarcodeLabel _label;
        public BarcodeLabel Label
        {
            get { return _label; }
            set
            {
                _label = value;
                if (_label != null)
                {
                    ctrl_BarcodeElements.Tag = Tag;
                    ctrl_BarcodeDisplay.Label = ctrl_BarcodeElements.Label = _label;
                }
            }
        }

        public BarcodeLabelCtrl()
        {
            InitializeComponent();
            
            _label = new BarcodeLabel();

            ctrl_BarcodeElements = new BarcodeElementsCtrl();
            ctrl_BarcodeElements.Dock = DockStyle.Fill; 
            ctrl_BarcodeElements.OnChanged += ctrl_BarcodeElements_OnChanged;
            splitContainer1.Panel1.Controls.Add(ctrl_BarcodeElements);

            ctrl_BarcodeDisplay = new BarcodeDisplayCtrl();
            ctrl_BarcodeDisplay.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(ctrl_BarcodeDisplay);
        }

        void ctrl_BarcodeElements_OnChanged(object sender, EventArgs e)
        {
            ctrl_BarcodeDisplay.Label = _label = ctrl_BarcodeElements.Label;
        }
    }
}
