using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR.Barcodes;

namespace InterpathBarcodeDesigner
{
    public static class DB
    {
        public static bool MakeConnection(out SqlConnection conn)
        {
            conn = null;
            string connStr = string.Empty;

            using (DBConnWin connWin = new DBConnWin())
            {
                if (connWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = connWin.Server;
                    builder.InitialCatalog = connWin.Database;
                    builder.UserID = connWin.Username;
                    builder.Password = connWin.Password;
                    connStr = builder.ToString();

                    if (connWin.Remember)
                    {
                        Properties.Settings.Default.ConnectionString = connStr;
                        Properties.Settings.Default.Save();
                    }

                    return DB.TryConnection(connStr, out conn);
                }
            }

            return false;
        }

        public static bool TryConnection(string connectionString, out SqlConnection conn)
        {
            conn = new SqlConnection();

            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }

        public static Dictionary<string, BarcodeLabel> GetBarcodLabelsFromDB(SqlConnection conn)
        {
            Dictionary<string, BarcodeLabel> labels = new Dictionary<string, BarcodeLabel>(0);

            try
            {
                if (conn != null && conn.State != ConnectionState.Open) { conn.Open(); }

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LIS.GetBarcodeLabelTemplates";
                cmd.CommandTimeout = 90;

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable data = new DataTable();
                data.Load(reader);
                reader.Close();

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    BarcodeLabel label;
                    string name = data.Rows[i]["Name"].ToString();
                    if (Common.TryMakeLabelFromJSON(data.Rows[i]["JSON"].ToString(), out label))
                    {
                        if (labels.ContainsKey(name)) { labels[name] = label; }
                        else { labels.Add(name, label); }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { if (conn != null && conn.State == ConnectionState.Open) { conn.Close(); } }

            return labels;
        }

        public static bool GetBarcodLabelFromDB(string name, out BarcodeLabel label)
        {
            label = null;
            SqlConnection conn = null;

            try
            {
                if (MakeConnection(out conn))
                {
                    if (conn != null && conn.State != ConnectionState.Open) { conn.Open(); }

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LIS.GetBarcodeLabelTemplateByName";
                    cmd.CommandTimeout = 90;
                    cmd.Parameters.AddWithValue("Name", name);

                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable data = new DataTable();
                    data.Load(reader);
                    reader.Close();

                    if (data.Rows.Count == 1)
                    {
                        return Common.TryMakeLabelFromJSON(data.Rows[0]["JSON"].ToString(), out label);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { if (conn != null && conn.State == ConnectionState.Open) { conn.Close(); } }

            return false;
        }

        public static bool UpdateBarcodLabelByName(string name, BarcodeLabel label)
        {
            SqlConnection conn = null;

            try
            {
                if (MakeConnection(out conn))
                {
                    if (conn != null && conn.State != ConnectionState.Open) { conn.Open(); }

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LIS.UpdateBarcodeLabelTemplate";
                    cmd.CommandTimeout = 90;
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("JSON", label.ToJSON());

                    int result = cmd.ExecuteNonQuery();

                    return result == 1;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { if (conn != null && conn.State == ConnectionState.Open) { conn.Close(); } }

            return false;
        }

        public static bool AddBarcodLabelToDB(string name, BarcodeLabel label)
        {
            SqlConnection conn = null;

            try
            {
                if (MakeConnection(out conn))
                {
                    if (conn != null && conn.State != ConnectionState.Open) { conn.Open(); }

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LIS.AddBarcodeLabelTemplate";
                    cmd.CommandTimeout = 90;
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("JSON", label.ToJSON());

                    int result = cmd.ExecuteNonQuery();

                    return result == 1;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { if (conn != null && conn.State == ConnectionState.Open) { conn.Close(); } }

            return false;
        }
    }
}
