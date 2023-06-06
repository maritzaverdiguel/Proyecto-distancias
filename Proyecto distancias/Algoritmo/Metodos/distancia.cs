using Proyecto_distancias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_distancias.Algoritmo.Metodos
{
    public class distancia
    {
       


        public List<Cliente> GenerarListaCliente(int limiteinferior, int limitesuperior,
            int clientes)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Random aleatorio2 = new Random(Environment.TickCount);

            for (int j = 0; j < clientes; j++)
            {
                Cliente cliente = new Cliente();
                int valor1 = aleatorio2.Next(limiteinferior, limitesuperior);
                int valor2 = aleatorio2.Next(limiteinferior, limitesuperior);
                int valor3 = aleatorio2.Next(0, 1000);
                int valor4 = aleatorio2.Next(1, 30);
                int valor5 = aleatorio2.Next(1, 3);
                cliente.Mes = valor4;
                cliente.Día = valor5;
                cliente.idCliente = j + 1;
                cliente.demanda = valor3;
                cliente.latitud = valor1;
                cliente.longitud = valor2;
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }






        public double[,] EncontrarDistancias(
            List<Cliente> listaClientes)
        {
            double[,] matrizDistancias = new double[listaClientes.Count(), listaClientes.Count()];

            int i = 0;
            foreach (Cliente cliente in listaClientes)
            {
                int j = 0;
                foreach (Cliente cliente2 in listaClientes)
                {

                    double distanciae = Math.Sqrt(Math.Pow((cliente.latitud - cliente2.latitud), 2) +
                        Math.Pow((cliente.longitud - cliente2.longitud), 2));

                    matrizDistancias[i, j] = distanciae;

                    cliente.distancia = distanciae;
                    j++;

                }

                
                i++;


            }



            return matrizDistancias;
        }

        public void AlgoritmoSimulacion(int limiteinferior, int limitesuperior,
            int clientes) 
        {
            List<Cliente> listaClientes= GenerarListaCliente(limiteinferior,  limitesuperior, clientes);
            double[,] matrizDistancias= EncontrarDistancias(listaClientes);
        }


    }



}
