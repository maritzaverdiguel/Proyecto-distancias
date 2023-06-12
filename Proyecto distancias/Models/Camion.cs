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
       public List<Camion> listaCamionesTardios = new List<Camion>();
        public List<Camion> utilizacioncamion = new List<Camion>();

        public double fechaInicioAcumulado { get; set; }

        public double ultimoCliente { get; set; }

        public int LlegadaTardia { get; set; }

        public double capacidadcamion = 5000;
        public double cargaporcamion { get; set; }
        public double uti { get; set; }

    }
}
