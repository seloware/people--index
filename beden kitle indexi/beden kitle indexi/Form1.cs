using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beden_kitle_indexi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text);
            int kilo = Convert.ToInt32(textBox2.Text);
            int bke =Convert.ToInt32( kilo /( boy * boy));

            sonuçlabel.Text = Convert.ToString(bke);
            if (bke < 18)
            {

                durumlabel.Text = "ZAYIF";
            }
            else if(bke>18 && 25 > bke)
            {
                durumlabel.Text = "NORMAL";


            }
            else if(bke > 25)
            {
                durumlabel.Text = "KİLOLU";
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
