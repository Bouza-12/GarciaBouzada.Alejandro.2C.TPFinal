using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{

    public class Practica
    {
        private static Dictionary<EPracticas, double> practicas;

        private int idPractica;
        private double precio;
        private string practicaNombre;

        static Practica()
        {
            practicas = new Dictionary<EPracticas, double>();
        }
        public Practica()
        {

        }

        public Practica(EPracticas practica, double precio)
        {
            this.practicaNombre = practica.ToString();
            this.precio = precio;
        }

        public string PracticaNombre { get => practicaNombre; set => practicaNombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int IdPractica { get => idPractica; set => idPractica = value; }
    }
}
