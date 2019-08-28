using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class db
    {
        static string vb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Database2.accdb";
        public static OleDbConnection baglanti()
        {
            OleDbConnection conn = new OleDbConnection(vb);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            return conn;
        }
    }
}