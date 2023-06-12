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
        public void GenerarCamiones(int n)
        {

            for (int i = 0; i < n; i++)
            {
                
                Camion camion1 = new Camion();
                camion1.fechaInicioAcumulado = 0;
                camion1.idCamion = i;

                listaCamiones.Add(camion1);

                

            }

            
        }


        public void AsignarSecuenciar(List<Cliente> listaClientes, int n, double[,] matrizDistancias) 
        {
            listaClientes.OrderBy(x => x.Día).ToList();

            GenerarCamiones(n);


            Random camionaleatorio = new Random(Environment.TickCount);

       
            //secuenciar.EncontrarDistancias(listaClientes);



            double[,] matriztiempos = new double[listaClientes.Count(), listaClientes.Count()];

            Cliente clientes = new Cliente();
            double velocidad = 80;


            int i = 0;
            foreach (Cliente cliente in listaClientes)
            {
                int j = 0;
                foreach (Cliente cliente2 in listaClientes)
                {

                    double tiempo = matrizDistancias[cliente.idCliente-1, cliente2.idCliente-1] / velocidad;


                    matriztiempos[i, j] = tiempo;


                    j++;

                }
                i++;


            }
    

            


            foreach (Cliente cliente in listaClientes) 
            {

                int k = camionaleatorio.Next(0, n);
                Camion camionAsigando = listaCamiones[k];
                if (camionAsigando.listaClientesAsignados.Count() == 0)
                {
                    camionAsigando.fechaInicioAcumulado = camionAsigando.fechaInicioAcumulado + 0;
                }
                else {
                    camionAsigando.fechaInicioAcumulado = camionAsigando.fechaInicioAcumulado + matriztiempos[(int)camionAsigando.ultimoCliente,cliente.idCliente];
                }
                camionAsigando.ultimoCliente = cliente.idCliente;

                camionAsigando.listaClientesAsignados.Add(cliente);
            }
        }
       





            
    }
}
