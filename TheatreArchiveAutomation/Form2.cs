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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void listeleme()
        {
            listView1.Items.Clear();
            OleDbConnection conn = db.baglanti();
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = conn;
            komut = new OleDbCommand("select * from Tablo1 where oyunadi like'" + textBox1.Text + "%'", conn);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["oyunadi"].ToString());
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listeleme();
        }
    }
}
