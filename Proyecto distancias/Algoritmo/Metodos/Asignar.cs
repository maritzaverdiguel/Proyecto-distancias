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
            listaClientes.OrderBy(x => x.TiempoEsperado).ToList();

            GenerarCamiones(n);


            Random camionaleatorio = new Random(Environment.TickCount);

       
            //secuenciar.EncontrarDistancias(listaClientes);



            double[,] matriztiempos = new double[listaClientes.Count(), listaClientes.Count()];

            Cliente clientes = new Cliente();
            double velocidad = 40;


            
            
            
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

                int k = camionaleatorio.Next(0, n-1);
                Camion camionAsigando = listaCamiones[k];
                if (camionAsigando.listaClientesAsignados.Count() == 0)
                {
                    camionAsigando.fechaInicioAcumulado = camionAsigando.fechaInicioAcumulado + 0;
                }
                else {
                    camionAsigando.fechaInicioAcumulado = camionAsigando.fechaInicioAcumulado + matriztiempos[(int)camionAsigando.ultimoCliente-1,cliente.idCliente-1];
                }
                camionAsigando.ultimoCliente = cliente.idCliente;
                cliente.TiempodeLLegada= camionAsigando.fechaInicioAcumulado;
                camionAsigando.listaClientesAsignados.Add(cliente);
            }
        }

        //coregir
       public int  Kpi1(double TiempoEsperado, double TiempodeLLegada, List<Cliente> listaClientes)
        {
            Camion camion = new Camion();
            camion.LlegadaTardia = 0;
            int tardios = 0;
            foreach (Cliente cliente in listaClientes)
            { 
                
                if (cliente.TiempodeLLegada > cliente.TiempoEsperado)

                {
                    tardios++;

                }

                else
                {
                   // camion.LlegadaTardia = 0;
                }
                //camion.listaCamionesTardios.Add(camion);
            }
            return tardios;
        }

       
        public double Kpi2 (List<Camion> listaCamiones)
        {
            Camion camion1 = new Camion();
            double maximo = 0, minimo = 99999999;
            foreach (Camion camion in listaCamiones)

            {
                double asignadoCamion = 0;
                foreach (Cliente cliente in camion1.listaClientesAsignados) 
                {
                    asignadoCamion = cliente.demanda + asignadoCamion;
                }
                if (asignadoCamion < minimo) 
                {
                    minimo = asignadoCamion;
                }
                if (maximo < asignadoCamion)
                {
                    maximo = asignadoCamion;
                }
            }
            return maximo;
        }            
    }
}
