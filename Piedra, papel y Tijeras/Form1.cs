using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra__papel_y_Tijeras
{
    public partial class Form1 : Form
    {
        int contarPuntos = 0, contarPuntosPC = 0;
        string Jugador = "", Computadora = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] seleccion = {"Piedra", "Papel", "Tijeras" };
            Random random = new Random();
            if (rtnPiedra.Checked == true)
            {
                Jugador = "Piedra";
            }
            else if (rtnPapel.Checked == true)
            {
                Jugador = "Papel";
            }
            else if (rtnTijeras.Checked == true)
            {
                Jugador = "Tijeras";
            }
            else {
                MessageBox.Show("Selecciona una opcion disponible");

            }

            Computadora = seleccion[random.Next(0, 3)];
            if (Computadora=="Piedra") 
            { rtnBotPiedra.Checked = true; }
            else if(Computadora=="Papel")
            {
                rtnBotPapel.Checked = true;
            }
            else
            {
                rtnBotTijeras.Checked= true;
            }
            //Comparando los resultados
            if (Computadora == Jugador)
            {
                lblGanador.ForeColor = Color.White;
                lblGanador.BackColor = Color.White;
                lblGanador.Text = "Empate";
            }
            else if ((Jugador == "Piedra" && Computadora == "Tijeras") || (Jugador == "Papel" && Computadora == "Piedra") || (Jugador == "Tijeras" && Computadora == "Papel"))

            {
                lblGanador.BackColor = Color.DarkGoldenrod;
                lblGanador.ForeColor = Color.White;
                lblGanador.Text = "Ganaste >:)";
                contarPuntos++;
                textBox1.Text = contarPuntos.ToString();
            }
            else
            {
                lblGanador.BackColor = Color.DarkGoldenrod;
                lblGanador.ForeColor = Color.White;
                lblGanador.Text = "Sorry nub";
                contarPuntosPC++;
                textBox2.Text = contarPuntos.ToString();
            }
            if (contarPuntos == 3) 
            {
                MessageBox.Show("Felicidades, Ganaste el juego");
            } else if (contarPuntosPC == 3)
            {
                MessageBox.Show("La computadora gano, Sorry nub");
            }
            if (contarPuntos == 3)
            {
                Close();
            }
            else if (contarPuntosPC == 3)
            {
                Close();
            }

        }
    }
}
