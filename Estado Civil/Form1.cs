using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estado_Civil
{
    public partial class Form1 : Form
    {
        string EstadoCivil, Genero, Nombre, Apellido;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(txtApellido.Text))

            {
                MessageBox.Show("Por favor no dejes campos vacios");
            }
            else
            {
                Nombre = textBox1.Text;
                Apellido = txtApellido.Text;
                
            }
            if (rtnCasado.Checked == true)
            {
               EstadoCivil = "Casado";

            }
            else
            {
                EstadoCivil = "Soltero";
            }
            if (rtnMasc.Checked == true)
            {
                Genero = "Masculino";
            }
            else
            {
                Genero = "Femenino";
            }
            lblImprimir.Text = "Eres" Nombre +  Apellido "Con estado civil de:" EstadoCivil "y tu genero es: "+ Genero;
        }
    }
}
