using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_distancias.Models
{
    public class Camion
    {
        public int idCamion { get; set; }

        public List<Cliente> listaClientesAsignados = new List<Cliente>();
    }
}
