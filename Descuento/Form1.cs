using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuento
{
    public partial class Form1 : Form
    {
        //Variable global
        double descuento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, precio;
            if (string.IsNullOrEmpty(textBox1.Text))

            {
                MessageBox.Show("Por favor no dejes campos vacios");
            }
            else
            {
                precio = double.Parse(textBox1.Text);
                //El radioButtom tiene el evento chececk que me sirve para saber que rádio seleccione
                if (rtn5porciento.Checked == true)
                {
                    descuento = 0.05 * precio;
                    resultado = precio - descuento;
                    txtTotal.Text = resultado.ToString("N2");

                }
                else if (rtn10porciento.Checked == true)
                {
                    descuento = 0.10 * precio;
                    resultado = precio - descuento;
                    txtTotal.Text = resultado.ToString("N2");

                }
                else if (rtn20porciento.Checked == true)
                {
                    descuento = 0.20 * precio;
                    resultado = precio - descuento;
                    txtTotal.Text = resultado.ToString("N2");

                }
                else {
                    lblnegativo.ForeColor = Color.YellowGreen;

                    lblnegativo.BackColor = Color.Yellow;

                    lblnegativo.Text = "No se aplico ningun descuento";

                    txtTotal.Text = precio.ToString("N2");
                }

            }

        }
    }
}
