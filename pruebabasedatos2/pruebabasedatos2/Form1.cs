using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebabasedatos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
            conexion.Open();
            string descri = textBox1.Text;
            string precio = textBox2.Text;
            string cadena = "insert into articulos(descripcion,precio) values ('" + descri + "'," + precio + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
            conexion.Open();
            string cadena = "select codigo, descripcion, precio from articulos";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                textBox3.AppendText(" ");
                textBox3.AppendText(registros["codigo"].ToString());
                textBox3.AppendText(" - ");
                textBox3.AppendText(registros["descripcion"].ToString());
                textBox3.AppendText(" - ");
                textBox3.AppendText(registros["precio"].ToString());
                textBox3.AppendText(Environment.NewLine);
                
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textBox3 = "";
        }
    }
}
