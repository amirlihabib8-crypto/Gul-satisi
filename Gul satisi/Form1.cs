using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gul_satisi
{
    public partial class Form1 : Form
    {
        double total=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(textBox1.Text))|| (string.IsNullOrEmpty(textBox2.Text))|| (string.IsNullOrEmpty(textBox3.Text)))
            {
                MessageBox.Show("Zehmet olmasa butun xanalari doldurun");
            }
            else
            {
                string gul_adi = textBox1.Text;
                int say = Convert.ToInt32(textBox2.Text);
                double qiymet = Convert.ToDouble(textBox3.Text);
                double yekunqiymet = say * qiymet;

                dataGridView1.Rows.Add(gul_adi, say, qiymet, yekunqiymet);
                total += yekunqiymet;
                label4.Text = "Toplam gəlir: " + total;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            

            
          

            
         
        }
    }
}
