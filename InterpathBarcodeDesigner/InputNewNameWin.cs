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
    public partial class InputNewNameWin : Form
    {
        public string NewName { get { return textBox_Name.Text.Trim(); } }

        public InputNewNameWin()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            textBox_Name.Focus();

            textBox_Name.SelectAll();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
