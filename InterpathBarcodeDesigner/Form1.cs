using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using BarcodeLib;
using PR.Barcodes;
using System.Diagnostics;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace InterpathBarcodeDesigner
{
    public partial class Form1 : Form
    {
        public SqlConnection _conn;

        public Form1()
        {
            InitializeComponent();

            Assembly assembly = Assembly.LoadFrom("PR.Barcodes.dll");
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text = string.Format("PR.Barcodes.dll (v{0})", fvi.FileVersion);
        }

        public void Initialize()
        {
            if (DB.MakeConnection(out _conn))
            {
                InitializeTabs();
                statusLabel.Text = string.Format("Connected to {0}", _conn.DataSource);
            }
            else
            {
                statusLabel.Text = "Disconnected";
            }
        }

        public void InitializeTabs()
        {
            Dictionary<string, BarcodeLabel> barcodeLabels = DB.GetBarcodLabelsFromDB(_conn);

            tabControl_Labels.TabPages.Clear();

            foreach (KeyValuePair<string, BarcodeLabel> pair in barcodeLabels)
            {
                AddTabPage(false, pair.Key, pair.Value);
            }
        }

        public void InitializeTabsFromAssembly()
        {
            Dictionary<string, BarcodeLabel> barcodeLabels = Common.GetBarcodeLabelInstancesFromAssembly();

            tabControl_Labels.TabPages.Clear();

            foreach (KeyValuePair<string, BarcodeLabel> pair in barcodeLabels)
            {
                AddTabPage(false, pair.Key, pair.Value);
            }
        }

        private void AddTabPage(bool isNew, string title, BarcodeLabel label)
        {
            BarcodeLabelCtrl bclCtrl = new BarcodeLabelCtrl();
            bclCtrl.Dock = DockStyle.Fill;
            bclCtrl.Tag = new LabelTabInfo { IsNew = isNew, Title = title };
            bclCtrl.Label = label;

            MenuItem mitab = new MenuItem();
            mitab.Text = "Close";
            mitab.Click += mitab_Click;

            TabPage page = new TabPage(title);
            page.Controls.Add(bclCtrl);
            page.ContextMenu = new System.Windows.Forms.ContextMenu();
            page.ContextMenu.MenuItems.Add(mitab);
            page.ContextMenu.Tag = page;

            tabControl_Labels.TabPages.Add(page);
        }

        void mitab_Click(object sender, EventArgs e)
        {
            tabControl_Labels.TabPages.Remove((TabPage)((ContextMenu)((MenuItem)sender).Parent).Tag);
        }

        private void menu_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_File_Connect_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void menu_File_New_Click(object sender, EventArgs e)
        {
            AddTabPage(true, "Untitled", new BarcodeLabel());
            tabControl_Labels.SelectTab(tabControl_Labels.TabPages.Count - 1);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                if (_conn != null) 
                {
                    if (_conn.State == ConnectionState.Open) { _conn.Close(); }

                    _conn.Dispose();
                }
            }
            finally { base.OnClosing(e); }
        }
    }
}
