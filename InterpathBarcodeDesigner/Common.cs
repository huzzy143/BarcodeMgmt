using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR.Barcodes;
using Newtonsoft.Json;

namespace InterpathBarcodeDesigner
{
    public static class Common
    {
        public static bool TryMakeLabelFromJSON(string json, out BarcodeLabel label)
        {
            label = null;

            try
            {
                label = (BarcodeLabel)JsonConvert.DeserializeObject(json, BarcodeLabel._type);

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }

        public static Dictionary<string, BarcodeLabel> GetBarcodeLabelInstancesFromAssembly()
        {
            Dictionary<string, BarcodeLabel> barcodeLabels = new Dictionary<string, BarcodeLabel>(0);

            RuntimeTypeHandle handle = typeof(BarcodeLabel).TypeHandle;

            Type[] types = Assembly.LoadFrom("PR.Barcodes.dll").GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].BaseType.TypeHandle.Equals(handle))
                {
                    barcodeLabels.Add(types[i].Name, (BarcodeLabel)Activator.CreateInstance(types[i]));
                }
            }

            return barcodeLabels;
        }
    }
}
