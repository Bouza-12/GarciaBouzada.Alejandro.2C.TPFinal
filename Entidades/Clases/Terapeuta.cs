using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Terapeuta : Persona
    {
        List<EPracticas> practicasHabilitadas;
        private int idTerapeuta;

        private static int maxId;
        private static int NewId
        {
            get
            {
                maxId++;
                return maxId;
            }
        }

        public Terapeuta(int idTerapeuta, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            practicasHabilitadas = new List<EPracticas>();
        }


    }
}
