using Proyecto_distancias.Algoritmo.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
              // FuncionEuclideana algoritmo1=new FuncionEuclideana();

                if (clientes > 0 &&  clientes < 18 && limiteinferior > -21 && limiteinferior < 21 && limitesuperior < 21 && limitesuperior > -21 && limitesuperior2 < 21 && limitesuperior2 > -21 && limiteinferior2 > -21 && limiteinferior2 < 21)
                {
                    List<int> LVA = algoritmo.distanciasaleatorias(limiteinferior, limitesuperior, clientes);
                    List<int> LVA2 = algoritmo.distanciasaleatorias2(limiteinferior2, limitesuperior2, clientes);
                  //  List<int> EU = algoritmo1.Euclideana;



                    llenarGrid(clientes, LVA, LVA2);
                }
                else
                {
                    MessageBox.Show("Una de las condiciones es incorrecta, favor de revisar");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("vuelve a intentar");

            }


        }

        public void llenarGrid(int numeroDatos, List<int> listaInicial, List<int> listaInicial2)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
         // string numeroColumna4 = "4";
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Cliente");
            dataGridView1.Columns.Add(numeroColumna2, "X");
            dataGridView1.Columns.Add(numeroColumna3, "Y");
          // dataGridView1.Columns.Add(numeroColumna4, "Distancia");
            for (int i = 0; i < numeroDatos; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = (listaInicial[i]).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = (listaInicial2[i]).ToString();
              //  dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = (listaInicial3[i]).ToString();
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
    }
}
