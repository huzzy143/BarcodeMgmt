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
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;

namespace InterpathBarcodeDesigner
{
    public partial class BarcodeElementsCtrl : UserControl
    {
        public event EventHandler OnChanged;

        private BarcodeLabel _label;
        public BarcodeLabel Label
        {
            get { return _label; }
            set
            {
                _label = value;
                if (_label != null)
                {
                    AddElementCtrls();
                    UpdateCtrlsFromBarcode();
                }
                else
                {
                    txt_JSON.Text = string.Empty;
                }
            }
        }

        public BarcodeElementsCtrl()
        {
            InitializeComponent();

            _label = new BarcodeLabel();
        }

        public void AddElementCtrls()
        {
            panelCtrls.Controls.Clear();

            BarcodeLabelElement[] elements = Label.Elements.ToArray();
            
            for (int i = elements.Length - 1; i > -1; i--)
            {
                ElementCtrl elemCtrl = new ElementCtrl(elements[i]);
                elemCtrl.OnChanged += elemCtrl_OnChanged;
                elemCtrl.Dock = DockStyle.Top;
                panelCtrls.Controls.Add(elemCtrl);
            }
        }

        private void UpdateCtrlsFromBarcode()
        {
            this.elementCtrl_Barcode.Element = Label.Barcode;
            this.elementCtrl_Barcode.ElementName = Label.Barcode.Title;
            this.elementCtrl_Barcode.ElementText = Label.Barcode.Text;
            this.elementCtrl_Barcode.Element.Area = Label.Barcode.Area;
            this.elementCtrl_Barcode.Element.FontName = Label.Barcode.FontName;
            this.elementCtrl_Barcode.Element.FontSize = Label.Barcode.FontSize;
            this.elementCtrl_Barcode.Element.FontStyle = Label.Barcode.FontStyle;
            this.elementCtrl_Barcode.Element.Forecolor = Label.Barcode.Forecolor;
            this.elementCtrl_Barcode.ElementText = Label.Barcode.Text;

            txt_JSON.Text = JsonHelper.FormatJson(_label.ToJSON());
        }

        private void UpdateBarcodeFromCtrls()
        {
            Label.Barcode.Title = this.elementCtrl_Barcode.ElementName;
            Label.Barcode.Text = this.elementCtrl_Barcode.ElementText;
            Label.Barcode.Area = this.elementCtrl_Barcode.Element.Area;
            Label.Barcode.FontName = this.elementCtrl_Barcode.Element.FontName;
            Label.Barcode.FontSize = this.elementCtrl_Barcode.Element.FontSize;
            Label.Barcode.FontStyle = this.elementCtrl_Barcode.Element.FontStyle;
            Label.Barcode.Forecolor = this.elementCtrl_Barcode.Element.Forecolor;
            Label.Barcode.Text = this.elementCtrl_Barcode.ElementText;

            txt_JSON.Text = JsonHelper.FormatJson(_label.ToJSON());
        }

        void elemCtrl_OnChanged(object sender, EventArgs e)
        {
            txt_JSON.Text = JsonHelper.FormatJson(_label.ToJSON());

            if (OnChanged != null) { OnChanged(this, EventArgs.Empty); }
        }

        private void elementCtrl_Barcode_OnChanged(object sender, EventArgs e)
        {
            UpdateBarcodeFromCtrls();

            if (OnChanged != null) { OnChanged(this, EventArgs.Empty); }
        }

        private void button_FromJSON_Click(object sender, EventArgs e)
        {
            Label = (BarcodeLabel)JsonConvert.DeserializeObject(txt_JSON.Text.Trim(), BarcodeLabel._type);

            this.elementCtrl_Barcode.ElementText = Label.Barcode.Text;

            if (OnChanged != null) { OnChanged(this, EventArgs.Empty); }
        }

        private void button_SaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txt_JSON.Text.Trim());
            }
        }

        private void button_ReloadFromDB_Click(object sender, EventArgs e)
        {
            LabelTabInfo info = Tag as LabelTabInfo;
            if (info == null)
            {
                MessageBox.Show("Something went terribly wrong...but everything's OK!", "Unknown Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show(string.Format("Reload ({0}) from DB?", info.Title), string.Format("Reload {0}...", info.Title), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BarcodeLabel label;
                if (DB.GetBarcodLabelFromDB(info.Title, out label))
                {
                    Label = label;
                }
                else
                {
                    MessageBox.Show(string.Format("Could not retrieve a label definition using the name:\r\n{0}", info.Title), "Label not found...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_SaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                LabelTabInfo info = Tag as LabelTabInfo;
                if (info == null)
                {
                    MessageBox.Show("Something went terribly wrong...but everything's OK!", "Unknown Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (info.IsNew)
                {
                    using (InputNewNameWin newNameWin = new InputNewNameWin())
                    {
                        if (newNameWin.ShowDialog() == DialogResult.OK)
                        {
                            if (MessageBox.Show(string.Format("Add template ({0}) to DB?\r\nAre you sure?", newNameWin.NewName), string.Format("Add new template to DB: {0}", newNameWin.NewName), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (MessageBox.Show(string.Format("Really, really sure?", newNameWin.NewName), string.Format("Add new template to DB: {0}...", newNameWin.NewName), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    DB.AddBarcodLabelToDB(newNameWin.NewName, Label);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show(string.Format("Save changes ({0}) to DB?\r\nAre you sure?", info.Title), string.Format("Save changes {0}...", info.Title), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show(string.Format("Really, really sure?", info.Title), string.Format("Save changes {0}...", info.Title), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DB.UpdateBarcodLabelByName(info.Title, Label);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_AddNewElement_Click(object sender, EventArgs e)
        {
            BarcodeLabelElement elem = new BarcodeLabelElement();

            using (ElementPropsWin epropWin = new ElementPropsWin())
            {
                using (Font font = new Font(elem.FontName, elem.FontSize, elem.FontStyle))
                {
                    epropWin.Title = elem.Title;
                    epropWin.DefaultText = elem.Text;
                    epropWin.ElemArea = elem.Area;
                    epropWin.Rotation = elem.Rotation;
                    epropWin.FontName = font.Name;
                    epropWin.FontSize = font.Size;
                    epropWin.FontStyle = font.Style;
                    epropWin.ForecolorFromArgb = elem.Forecolor;
                }

                if (epropWin.ShowDialog() == DialogResult.OK)
                {
                    elem.Title = epropWin.Title;
                    elem.Text = epropWin.DefaultText;
                    elem.Area = epropWin.ElemArea;
                    elem.Rotation = epropWin.Rotation;
                    elem.FontName = epropWin.FontName;
                    elem.FontSize = epropWin.FontSize;
                    elem.FontStyle = epropWin.FontStyle;
                    elem.Forecolor = epropWin.ForecolorFromArgb;

                    Label.Elements.Add(elem);

                    AddElementCtrls();

                    txt_JSON.Text = JsonHelper.FormatJson(_label.ToJSON());

                    if (OnChanged != null) { OnChanged(this, EventArgs.Empty); }
                }
            }
        }
    }

    public class JsonHelper
    {
        private const string INDENT_STRING = "    ";
        public static string FormatJson(string str)
        {
            var indent = 0;
            var quoted = false;
            var sb = new StringBuilder();
            for (var i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                switch (ch)
                {
                    case '{':
                    case '[':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, ++indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case '}':
                    case ']':
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, --indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        sb.Append(ch);
                        break;
                    case '"':
                        sb.Append(ch);
                        bool escaped = false;
                        var index = i;
                        while (index > 0 && str[--index] == '\\')
                            escaped = !escaped;
                        if (!escaped)
                            quoted = !quoted;
                        break;
                    case ',':
                        sb.Append(ch);
                        if (!quoted)
                        {
                            sb.AppendLine();
                            Enumerable.Range(0, indent).ForEach(item => sb.Append(INDENT_STRING));
                        }
                        break;
                    case ':':
                        sb.Append(ch);
                        if (!quoted)
                            sb.Append(" ");
                        break;
                    default:
                        sb.Append(ch);
                        break;
                }
            }
            return sb.ToString();
        }
    }

    static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
        {
            foreach (var i in ie)
            {
                action(i);
            }
        }
    }
}
