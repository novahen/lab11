using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11_Zhukov_Tsvetkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = ""; label4.Text = ""; label5.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void But1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Cut();
            richTextBox1.Text = "Сегодня\n";
            DateTime thisDay = DateTime.Today;
            richTextBox1.Text += thisDay.ToString()+"\n";
            richTextBox1.Text += thisDay.ToString("d")+"\n";
            richTextBox1.Text += thisDay.ToString("D") + "\n";
            richTextBox1.Text += thisDay.ToString("g") + "\n";
            richTextBox1.Text += DateTime.Now.TimeOfDay.ToString()+"\n";
            var someTime = new DateTime();
            richTextBox1.Text += someTime + "\n";
            richTextBox1.Text += DateTime.Now.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Today;
            label2.Text = "День "+day.Day.ToString();
            label3.Text = "Месяц " + day.Month.ToString();
            label4.Text = "Год " + day.Year.ToString();
            label5.Text =  day.DayOfWeek.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = ""; label4.Text = ""; label5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime Day = DateTime.Now;
            DateTime Yest = Day.AddDays(1);
            richTextBox2.Text += "Завтра " + Yest.ToString() + "\n";
            Yest = Day.AddDays(7);
            richTextBox2.Text += "Через неделю " + Yest.ToString()+"\n";
            DateTime Days = DateTime.Today;
            richTextBox2.Text += "Только дата " + Days.ToString("d");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Years = DateTime.Today;
                DateTime Age = Convert.ToDateTime(textBox1.Text);
                int AGE = Years.Year - Age.Year;
                richTextBox2.Text = "Возраст: " + AGE.ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный ввод даты!!!");
                textBox1.Clear();
            }
        }

    }
}
