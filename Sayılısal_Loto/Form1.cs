using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayılısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            
        }

        int sayac = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1,50);
            int sayi2 = rnd.Next(1, 50);
            int sayi3 = rnd.Next(1, 50);
            int sayi4 = rnd.Next(1, 50);
            int sayi5 = rnd.Next(1, 50);
            int sayi6 = rnd.Next(1, 50);

            int[] dizi = { sayi, sayi2, sayi3, sayi4, sayi5, sayi6 };

            textBox1.Text = sayi.ToString();
            textBox2.Text = sayi2.ToString();
            textBox3.Text = sayi3.ToString();
            textBox4.Text = sayi4.ToString();
            textBox5.Text = sayi5.ToString();
            textBox6.Text = sayi6.ToString();

           
            

                sayac++;

                if (sayac == 10)
                {
                
                    timer1.Stop();

                if (textBox7.Text == textBox1.Text 
                    &&    
                textBox8.Text == textBox2.Text 
                &&
                textBox9.Text == textBox3.Text
                &&
                textBox10.Text == textBox4.Text 
                &&
                textBox11.Text == textBox5.Text
                &&
                textBox12.Text == textBox6.Text)

                     MessageBox.Show("Tebrikler Kazandınız");
                
                else
                    MessageBox.Show("Kaybettiniz");
                

                MessageBox.Show("Şanslı numaralar: " + textBox1.Text + "  " +
                        textBox2.Text + "  " + textBox3.Text +
                        "  " + textBox4.Text + "  " + textBox5.Text + "  " +
                        textBox6.Text);

                sayac = 0;

                }

           
        }

       

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;


        }
    }
}
