using Proyecto_distancias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proyecto_distancias.Algoritmo.Metodos
{
    public class Asignar


    {
       
        distancia secuenciar = new distancia();
        List<Camion> listaCamiones = new List<Camion>();
        public void AsignarSecuenciar(List<Cliente> listaClientes, int n) 
        {
            listaClientes.OrderBy(x => x.Día).ToList();
            // Esto va en un for, quiero 5 camiones

            GenerarCamiones(n);

            Random camionaleatorio = new Random(Environment.TickCount);

       
            secuenciar.EncontrarDistancias(listaClientes);
            double[,] matriztiempos = new double[listaClientes.Count(), listaClientes.Count()];

            Cliente clientes = new Cliente();
            clientes.velocidad = 80;


            int i = 0;
            foreach (Cliente cliente in listaClientes)
            {
                int j = 0;
                foreach (Cliente cliente2 in listaClientes)
                {

                    double tiempo = cliente.distancia / cliente2.velocidad;


                    matriztiempos[i, j] = tiempo;


                    j++;

                }
                i++;


            }
    

            


                foreach (Cliente cliente in listaClientes) 


            {
                int k = camionaleatorio.Next(1, n);
                //cuando incia y cuando termina 


                listaCamiones[k].listaClientesAsignados.Add(cliente);
            }
        }
        public void GenerarCamiones(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Esto va en un for, quiero 5 camiones
                Camion camion1 = new Camion();

                camion1.idCamion = i;
                listaCamiones.Add(camion1);



            }
        }

           





            
    }
}
