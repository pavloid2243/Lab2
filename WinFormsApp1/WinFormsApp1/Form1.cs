using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.a.ToString();
            textBox2.Text = Properties.Settings.Default.b.ToString();
            textBox3.Text = Properties.Settings.Default.d.ToString();
            textBox4.Text = Properties.Settings.Default.c.ToString();
            textBox5.Text = Properties.Settings.Default.m.ToString();
            textBox6.Text = Properties.Settings.Default.n.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.label9.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, n, m, i, y;

            try
            {
                a = int.Parse(this.textBox1.Text);

                b = int.Parse(this.textBox2.Text);

                c = int.Parse(this.textBox4.Text);

                d = int.Parse(this.textBox3.Text);

                n = int.Parse(this.textBox6.Text);

                m = int.Parse(this.textBox5.Text);

                if (a > 23 || a < 0 || b < 0 || b > 59 || c < 0 || c > 23 || d < 0 || d > 59 || n < 0 || n > 23 || m < 0 | m > 59) {
                    MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.d = d;
            Properties.Settings.Default.n = n;
            Properties.Settings.Default.m = m;
            Properties.Settings.Default.Save();
            label9.Text =Logic.Logica(a, b, c, d, n, m);


            
        }
        
        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);



            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
    public class Logic
    {
        public static string Logica(int a, int b, int c, int d, int n, int m)
        {
            String s = "";
            if (n >= a && n <= c)
            {
                int r = 0;
                if (n == a && m >= b && a != c) { s = "Поезд стоит на платформе"; r++; }
                if (n > a || n < c) { s = "Поезд стоит на платформе"; r++; }
                if (n == c && m <= d && a != c) { s = "Поезд стоит на платформе"; r++; }
                if (a == c && m < d) { s = "Поезд стоит на платформе"; r++; }
                if (r == 0) s = "Поезд не стоит на платформе";
            }
            else
            {
                if (a > c)
                {
                    int r = 0;
                    if (n == a && m >= b) { s = "Поезд стоит на платформе"; r++; }
                    if (n > a || n < c) { s = "Поезд стоит на платформе"; r++; }
                    if (n == c && m <= d) { s = "Поезд стоит на платформе"; r++; }
                    if (r == 0) s = "Поезд не стоит на платформе";
                }
                else
                {
                    s = "Поезд не стоит на платформе";
                }
            }

            return (s);

        }
    }
}
