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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            listeleme();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void listeleme()
        {
            listView1.Items.Clear();
            OleDbConnection conn = db.baglanti();
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = conn;
            komut = new OleDbCommand("select * from Tablo1", conn);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Kimlik"].ToString());
                item.SubItems.Add(dr["oyunadi"].ToString());
                item.SubItems.Add(dr["yazar"].ToString());
                item.SubItems.Add(dr["oyuncusayisi"].ToString());
                item.SubItems.Add(dr["erkekosayisi"].ToString());
                item.SubItems.Add(dr["kadinosayisi"].ToString());
                item.SubItems.Add(dr["oynadigi"].ToString());
                item.SubItems.Add(dr["oyunturu"].ToString());
                listView1.Items.Add(item);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = db.baglanti();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = conn;
            if (listView1.SelectedIndices.Count > 0)
            {
                komut.CommandText = "Delete from Tablo1 where Kimlik=" + listView1.SelectedItems[0].Text + "";
                komut.ExecuteNonQuery();
            }
            else MessageBox.Show("Seçili bir alan yok.");
            conn.Close();
            listeleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }

                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
