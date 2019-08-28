using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
       OleDbConnection con; 
     
       OleDbCommand cmd;
     
        public Form3()
        {
        
       
        
       

        InitializeComponent(); {
        }
        }
    
         
         
         

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database2.accdb");
            
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Tablo1 (oyunadi,yazar,oyuncusayisi,erkekosayisi,kadinosayisi,oynadigi,oyunturu) values ('" + oyunaditxt.Text + "','" + yzrtxt.Text + "','" + oyncusayisitxt.Text + "','" + erkekoyuncutxt.Text + "','" + kdnoyuncutxt.Text + "','" + oynaditxt.Text + "','" + oyuntürütxt.Text + "')";
            int s = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("eklenmiştir", "uyarı",MessageBoxButtons.OK);
            Form4 ara = new Form4();
            ara.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void yzrtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
