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
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database2.accdb");
     
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 goster = new Form3();
            goster.ShowDialog();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
           
            Form2 goster = new Form2();
            goster.ShowDialog();
           

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void oyuntürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oyncusayisitxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void erkekoyuncutxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kdnoyuncutxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void oynaditxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void oyunaditxt_TextChanged(object sender, EventArgs e)
        {
            
            
     
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void yzrtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnoyunekle_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 goster = new Form3();
            goster.Show();
            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form4 goster = new Form4();
            goster.Show();
            
            
        }
    }
}
