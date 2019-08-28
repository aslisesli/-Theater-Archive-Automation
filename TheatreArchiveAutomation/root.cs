using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class root : Form
    {
        public root()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                OleDbConnection conn = db.baglanti();
                OleDbCommand komut = new OleDbCommand();
                OleDbDataReader dr;
                komut.Connection = conn;
                komut.CommandText = "SELECT * FROM admin where as='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Form4 ara = new Form4();
                    button1.Enabled = true;
                    ara.Show();
                    this.Hide();
                }
                else
                {
                    button1.Enabled = false;
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }

                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ara = new Form4();
            ara.Show();
            this.Hide();
        }
    }
}
