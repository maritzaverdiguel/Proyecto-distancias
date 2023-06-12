using Proyecto_distancias.Algoritmo.Metodos;
using Proyecto_distancias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_distancias
{
    public partial class Form1 : Form
    {

      
        public Form1()


             
        {
            InitializeComponent();
           
        }

    

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                
                int clientes = int.Parse(textBox3.Text);
                int limiteinferior = int.Parse(textBox1.Text);
                int limitesuperior = int.Parse(textBox2.Text);
                int limiteinferior2 = int.Parse(textBox5.Text);
                int limitesuperior2 = int.Parse(textBox4.Text);
                
                

                int n = int.Parse(textBox6.Text);
                double[,] matrizDistancias = new double[clientes, clientes];
                double TiempoEsperado = new  double();
                double TiempodeLLegada = new double();


                distancia algoritmo = new distancia();
                Asignar camiones = new Asignar();
                List<Camion> listaCamiones = new List<Camion>();

                if ( clientes<20)

                {
                    List<Cliente> listaClientes = algoritmo.GenerarClientes(limiteinferior, limitesuperior, limiteinferior2, limitesuperior2,
                  clientes);
                    matrizDistancias = algoritmo.MatrizDistancias(listaClientes);
                    camiones.AsignarSecuenciar(listaClientes, n, matrizDistancias);
                    camiones.Kpi1(TiempoEsperado, TiempodeLLegada, listaClientes);
                    camiones.Kpi2(listaCamiones);
                }
                    
                else
                {
                    MessageBox.Show("Uno de los valores introducidos es incorrecto");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("vuelve a intentar");

            }


        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
