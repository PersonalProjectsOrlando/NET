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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDSQLServer
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
            conexion.Open();
            string descri = textBox1.Text;
            string precio = textBox2.Text;
            string cadena = "insert into articulos(descripcion,precio) values (@descripcion,@precio)";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@precio", SqlDbType.Float);
            comando.Parameters["@descripcion"].Value = textBox1.Text;
            comando.Parameters["@precio"].Value = float.Parse(textBox2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
            conexion.Open();
            textBox3.Text = "";
            string cadena = "select codigo, descripcion, precio from articulos";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
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
            //SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
            conexion.Open();
            textBox3.Text = "";
            conexion.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection("server=DESKTOP-D9DPUOF ; database=base1 ; integrated security = true");
            conexion.Open();
            string cadena = "select descripcion, precio from articulos where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox4.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label6.Text = registro["descripcion"].ToString();
                label7.Text = registro["precio"].ToString();
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "select descripcion, precio from articulos where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox5.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label11.Text = registro["descripcion"].ToString();
                label12.Text = registro["precio"].ToString();
                button2.Enabled = true;
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "delete from articulos where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox5.Text);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                label11.Text = "";
                label12.Text = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
            //button6.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "select descripcion, precio from articulos where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox6.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox7.Text = registro["descripcion"].ToString();
                textBox8.Text = registro["precio"].ToString();
                button2.Enabled = true;
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "update articulos set descripcion=@descripcion, precio=@precio where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox6.Text);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters["@descripcion"].Value = textBox7.Text;
            comando.Parameters.Add("@precio", SqlDbType.Float);
            comando.Parameters["@precio"].Value = float.Parse(textBox8.Text);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
            //button8.Enabled = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
