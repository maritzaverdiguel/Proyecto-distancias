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
                int clientes = Int32.Parse(textBox3.Text);
                int limiteinferior = Int32.Parse(textBox1.Text);
                int limitesuperior = Int32.Parse(textBox2.Text);
                int limiteinferior2 = Int32.Parse(textBox5.Text);
                int limitesuperior2 = Int32.Parse(textBox4.Text);
               distancia algoritmo = new distancia();

                algoritmo.matriz(limiteinferior, limitesuperior2, limiteinferior2,limitesuperior,clientes);




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
    }
}
