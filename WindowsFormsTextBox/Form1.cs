using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            label2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
            label3.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Obtener el CheckBox que generó el evento
            CheckBox checkBox = sender as CheckBox;

            // Si el CheckBox que generó el evento está marcado, desmarcar los otros dos
            if (checkBox.Checked)
            {
                if (checkBox == checkBox1)
                {
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }
                else if (checkBox == checkBox2)
                {
                    checkBox1.Checked = false;
                    checkBox3.Checked = false;
                }
                else if (checkBox == checkBox3)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) {
                Text = "";
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                Text = checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                Text = "";
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                Text = checkBox2.Text;
            }
            else if (checkBox3.Checked == true)
            {
                Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                Text = checkBox3.Text;
            }
            else {
                Text = "";
            }
         }
    }
}
