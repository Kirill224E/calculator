using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBoxTemp; 
        private ComboBox comboBoxConv; 
        private Button buttonConv; 
        private Label labelResult; 
        private TextBox textBoxMin; 
        private TextBox textBoxMax; 
        private Button buttonRandom; 
        private Label labelRandom; 

        public Form1()
        {
            InitializeComponent();

            textBox1 = new TextBox();
            textBox1.Location = new Point(10, 10);
            textBox1.Size = new Size(100, 20);
            Controls.Add(textBox1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(115, 10);
            textBox2.Size = new Size(100, 20);
            Controls.Add(textBox2);

            textBox3 = new TextBox();
            textBox3.Location = new Point(240, 10);
            textBox3.Size = new Size(100, 20);
            textBox3.ReadOnly = true;
            Controls.Add(textBox3);

            button1 = new Button();
            button1.Text = "+";
            button1.Location = new Point(10, 40);
            button1.Size = new Size(50, 20);
            button1.Click += button1_Click;
            Controls.Add(button1);

            button2 = new Button();
            button2.Text = "-";
            button2.Location = new Point(60, 40);
            button2.Size = new Size(50, 20);
            button2.Click += button2_Click;
            Controls.Add(button2);

            button3 = new Button();
            button3.Text = "*";
            button3.Location = new Point(110, 40);
         
            button3.Size = new Size(50, 20);
            button3.Click += button3_Click;
            Controls.Add(button3);

            button4 = new Button();
            button4.Text = "/";
            button4.Location = new Point(10, 60);
            button4.Size = new Size(50, 20);
            button4.Click += button4_Click;
            Controls.Add(button4);

            button5 = new Button();
            button5.Text = "^";
            button5.Location = new Point(60, 60);
            button5.Size = new Size(50, 20);
            button5.Click += button5_Click;
            Controls.Add(button5);

            button6 = new Button();
            button6.Text = "√";
            button6.Location = new Point(110, 60);
            button6.Size = new Size(50, 20);
            button6.Click += button6_Click;
            Controls.Add(button6);

            textBoxTemp = new TextBox();
            textBoxTemp.Location = new Point(10, 80);
            textBoxTemp.Size = new Size(100, 20);
            Controls.Add(textBoxTemp);

            comboBoxConv = new ComboBox();
            comboBoxConv.Location = new Point(115, 80);
            comboBoxConv.Size = new Size(150, 20);
            comboBoxConv.Items.Add("Цельсий в Фаренгейт");
            comboBoxConv.Items.Add("Фаренгейт в Цельсий");
            comboBoxConv.SelectedIndex = 0;
            Controls.Add(comboBoxConv);

            buttonConv = new Button();
            buttonConv.Text = "Конвертировать";
            buttonConv.Location = new Point(10, 100);
            buttonConv.Size = new Size(100, 20);
            buttonConv.Click += buttonConv_Click;
            Controls.Add(buttonConv);

            labelResult = new Label();
            labelResult.Location = new Point(10, 120);
            labelResult.Size = new Size(150, 20);
            Controls.Add(labelResult);

            textBoxMin = new TextBox();
            textBoxMin.Location = new Point(10, 140);
            textBoxMin.Size = new Size(100, 20);
            Controls.Add(textBoxMin);

            textBoxMax = new TextBox();
            textBoxMax.Location = new Point(115, 140);
            textBoxMax.Size = new Size(100, 20);
            
            Controls.Add(textBoxMax);

            buttonRandom = new Button();
            buttonRandom.Text = "Случайное число";
            buttonRandom.Location = new Point(10, 160);
            buttonRandom.Size = new Size(100, 20);
            buttonRandom.Click += buttonRandom_Click;
            Controls.Add(buttonRandom);

            labelRandom = new Label();
            labelRandom.Location = new Point(10, 180);
            labelRandom.Size = new Size(150, 20);
            Controls.Add(labelRandom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double razn(double a, double b)
        {
            return a - b;
        }

        public static double umnog(double a, double b)
        {
            return a * b;
        }

        public static double del(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("Деление на ноль невозможно!");
                return 0;
            }
            return a / b;
        }

        public static double step(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double koren(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
double.TryParse(textBox2.Text, out double num2))
            {
                textBox3.Text = Convert.ToString(sum(num1, num2));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                textBox3.Text = Convert.ToString(razn(num1, num2));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                textBox3.Text = Convert.ToString(umnog(num1, num2));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                textBox3.Text = Convert.ToString(del(num1, num2));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                textBox3.Text = Convert.ToString(step(num1, num2));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                textBox3.Text = Convert.ToString(koren(num1, num2));
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа.");
            }
        }

        private void buttonConv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTemp.Text, out double temperature))
            {
                if (comboBoxConv.SelectedIndex == 0) 
                {
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    labelResult.Text = $"{fahrenheit:F2} °F";
                }
                else 
                {
                    double celsius = FahrenheitToCelsius(temperature);
                    labelResult.Text = $"{celsius:F2} °C";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение температуры.");
            }
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMin.Text, out int min) &&
                int.TryParse(textBoxMax.Text, out int max) &&
                min < max)
            {
                Random random = new Random();
                int randomNumber = random.Next(min, max + 1);
                labelRandom.Text = $"Случайное число: {randomNumber}"; ; // semicolon added here
            }
            else
            {
                MessageBox.Show("Введите корректные значения минимума и максимума (минимум меньше максимума).");
            }
        }

    }
}