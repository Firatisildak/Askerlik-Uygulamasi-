using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace askerlik_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            int a;
            int borc;
            a = Convert.ToInt32(maskedTextBox1.Text);
            if (a > 18 && a <= 30)
            {
                borc = (a - 18) * 5000;

            }
            else if (a > 30 && a <= 40)
            {
                borc = (a - 18) * 7000;
            }
            else if (a > 40)
            {
                borc = (a - 18) * 10000;

            }
            else
            {
                listBox1.Items.Add("gönüllü olarak gitmeyi seçtiniz tebrikler");
                listBox1.Items.Add( "borcunuz bulunmamaktadır");
                borc = 00;

            }

            label4.Text = borc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
            int b;
            double maas;
            b = Convert.ToInt32(maskedTextBox1.Text);
            if (b > 18 && b <= 30)
            {

                maas = (b - 18) * 500 + (2825 * (0.1) + 2825) ;

            }
            else if(b > 30 && b <= 40)
            {


                maas = (b - 18) * 650 + (2825 * (0.11) + 2825);


            }
            else
            {

                listBox1.Items.Add("emekli");

                maas = 2825;
            }


            label6.Text = maas.ToString();

        }
    }
}
