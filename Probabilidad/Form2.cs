using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilidad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Cambio = new Form1();
            Cambio.Visible = true;
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double euler = 2.7182818;
            string texto1;
            string texto2;
            string salida = "";
            bool errores = false;
            double miu;
            double x;
            double denominador;
            double numerador;
            int fac = 1;
            int z = 1;
            double resultado;
            double resultado1;
            // Eliminamos espacios de la cadena para evitar errores
            texto1 = textBox1.Text.Replace(" ", "");
            texto2 = textBox2.Text.Replace(" ", "");
            miu = Convert.ToDouble(texto1);
            x = Convert.ToDouble(texto2);
            if (texto1 == "" || texto2 == "")
            {
                errores = true;
                MessageBox.Show("Los campos no pueden estar vacios", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (x > 16)
            {
                errores = true;
                MessageBox.Show("Los pacientes que llegan en un dia no pueden ser mayores a 16", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                denominador = (Math.Pow(euler, (-miu))) * (Math.Pow(miu, (x)));

                while (z <= x)
                {
                    fac = fac * z;
                    z = z + 1;
                };
                resultado = denominador / fac;
                resultado1 = 100*Math.Round(resultado, 4);
                salida = salida + "Probabilidad resultante: ";
                salida = salida + Convert.ToString(resultado1) +"% "+  Environment.NewLine;
                salida = salida + "Procedimiento:" + Environment.NewLine;
                salida = salida + "Para realizar la siguiente operacion es necesario consultar la teoria puesta en este mismo programa." + Environment.NewLine + Environment.NewLine;
                salida = salida + "Calculamos el denominador que seria: " + "e ^ -" + miu + " * " + miu + " ^ " + x + Environment.NewLine;
                salida = salida + "Despues calcularemos el numerador, que como ya hemos visto en la teoria, es el factorial de " + x + " lo que pertenece a " + fac + Environment.NewLine;
                salida = salida + "Lo cual daria: " + resultado + " y aproximando = " + resultado1 +"%";
               textBox3.Text = salida;

            }
        }
    }
    
}

