using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.a.ToString();
            textBox2.Text = Properties.Settings.Default.b.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, i;
            textBox3.Text = "";
            try
            {
                a = Convert.ToInt32(textBox1.Text); // Данная строка подразумевает ввод только integer иначе выйдет ошибка
                b = Convert.ToInt32(textBox2.Text);// Данная строка подразумевает ввод только integer иначе выйдет ошибка
                if (a < 1 || b < 1)
                {
                    MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    return; // а затем прерываем обработчик
                }
                textBox3.Text = $"Прямоугольник размером {a} x {b}" + '\r' + '\n';
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // а затем прерываем обработчик
            }


            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.Save();

            textBox3.Text = Logic.Logica(a,b);

        }
       
        
        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (ActiveControl == textBox2) button1_Click(button1, null);
                SelectNextControl(ActiveControl, true, true, true, true);
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
    public static class Logic
    {
        public static string Logica(int a, int b)
        {
            String s = "";
            int i;
            for (i = 0; a != b; i++)
            {
                if (a > b)
                {
                    a = a - b;
                    s += $"Отрезаем квадрат размером {b} x {b}" + '\r' + '\n';
                }
                else
                {
                    b = b - a;
                    s += $"Отрезаем квадрат размером {a} x {a}" + '\r' + '\n';
                }
            }
            s += $"Отрезаем квадрат размером {a} x {a}\n" + '\r' + '\n' + $"Количество квадратов = {i+1} ";
            return s;
        }
    }
}
