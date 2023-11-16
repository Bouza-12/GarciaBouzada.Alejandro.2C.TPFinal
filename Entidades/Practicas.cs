using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EPracticas { Biodecodificacion, Reiki, Tarot };
    public class Practicas
    {
        private static Dictionary<EPracticas, string> practicas;

        private string practica;
        private string descripcion;
        private double precio;

        static Practicas()
        {
            practicas = new Dictionary<EPracticas, string>();
        }
        
        public Practicas(EPracticas practica, string descripcion )
        {
            this.practica = practica.ToString();
            this.descripcion = descripcion;
        }
    }
}
