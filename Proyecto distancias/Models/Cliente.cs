using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_distancias.Models
{
    public class Cliente
    {
        public double demanda { get; set; }
        public int latitud { get; set; }
        public int longitud { get; set; }
        public string idProducto { get; set; }

        public int idCliente { get; set; }
        public int Mes { get; set; }
        public int Día { get; set; }

        public int velocidad { get; set; }
        public double distancia{ get; set; }

        public Cliente() 
        { 
        
        }
    }
}
