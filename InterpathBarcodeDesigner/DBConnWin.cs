using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpathBarcodeDesigner
{
    public partial class DBConnWin : Form
    {
        private static bool _initialized = false;

        public bool Remember { get { return this.checkBoxRemember.Checked; } }

        public string Server { get { return textBox_Server.Text; } }

        public string Database { get { return textBox_Database.Text; } }

        public string Username { get { return textBox_Username.Text; } }
        
        public string Password { get { return textBox_Password.Text; } }

        public DBConnWin()
        {
            InitializeComponent();

            checkBoxRemember.Checked = Properties.Settings.Default.Remember;

            if (checkBoxRemember.Checked && Properties.Settings.Default.ConnectionString.Length > 0)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Properties.Settings.Default.ConnectionString);
                textBox_Server.Text = builder.DataSource;
                textBox_Database.Text = builder.InitialCatalog;
                textBox_Username.Text = builder.UserID;
                textBox_Password.Text = builder.Password;
            }

            _initialized = true;
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized) { return; }

            Properties.Settings.Default.Remember = checkBoxRemember.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
