using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Width = 640;
                Height = 480;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    Width = 800;
                    Height = 600;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        Width = 1024;
                        Height = 768;
                    }
                }
            }
            /*if (radioButton1.Checked == true) {
                Width = 640;
                Height = 480;
            } else if (radioButton2.Checked == true) {
                Width = 800;
                Height = 600;
            }
            else if (radioButton3.Checked == true)
            {
                Width = 1024;
                Height = 768;
            }*/
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked==true) {
                int val1 =int.Parse(textBox1.Text);
                int val2 = int.Parse(textBox2.Text);
                int suma = val1 + val2;
                //label5.Text = $"{suma}";
                label5.Text = suma.ToString();
            }
            else if (radioButton5.Checked == true)
            {
                int val1 = int.Parse(textBox1.Text);
                int val2 = int.Parse(textBox2.Text);
                int resta = val1 - val2;
                //label5.Text = $"{suma}";
                label5.Text = resta.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(comboBox1.Text);
            int verde = int.Parse(comboBox2.Text);
            int azul = int.Parse(comboBox3.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int f = 0; f <= 255; f++)
            {
                comboBox1.Items.Add(f.ToString());
                comboBox2.Items.Add(f.ToString());
                comboBox3.Items.Add(f.ToString());
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
