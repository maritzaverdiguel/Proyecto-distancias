using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_distancias.Algoritmo.Metodos
{
    public class distancia
    {
        public List<int> listaAleatorios = new List<int>();
        public List<int> distanciasaleatorias(int limiteinferior, int limitesuperior, int clientes)
        {
            Random aleatorio = new Random(Environment.TickCount);

            for (int i = 0; i < clientes; i++)
            {
            
                int valor = aleatorio.Next(limiteinferior, limitesuperior);
                
                listaAleatorios.Add(valor);
            }

            
            return listaAleatorios;
        }

       


        public List<int> listaAleatorios2 = new List<int>();
        public List<int> distanciasaleatorias2(int limiteinferior2, int limitesuperior2, int clientes)
        {
            Random aleatorio2 = new Random(Environment.TickCount);

            for (int j = 0; j < clientes; j++)
            {

                int valor2 = aleatorio2.Next(limiteinferior2, limitesuperior2);

                listaAleatorios2.Add(valor2);
            }


            return listaAleatorios2;
        }

    }

    public class FuncionEuclideana
    {
        public List<int> Euclideana = new List<int>();


        public void CalcularDistancias(List<int> listaAleatorios, List<int> listaAleatorios2)
        {
            for (int z = 0; z < listaAleatorios.Count; z++)
            {
                int latitud = 0;
                int longitud = 0;

                for (int n = 0; n < listaAleatorios.Count; n++)
                {
                    int latitud2 = listaAleatorios[n];
                    int longitud2 = listaAleatorios2[n];

                    int distX = latitud - latitud2;
                    int distY = longitud - longitud2;
                    double powX = Math.Pow(distX, 2);
                    double powY = Math.Pow(distY, 2);
                    double sumaXY = powX + powY;
                    double distanciaTotal = Math.Sqrt(sumaXY);
                    int distanciaTotalInt = Convert.ToInt32(distanciaTotal);

                    Euclideana.Add(distanciaTotalInt);
                }
            }

            return Euclideana;
        }
    }

    

    
}
