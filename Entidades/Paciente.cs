using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        List<EPracticas> practicas;
        private int id;
        public Paciente(string nombre, string apellido, int dni, DateTime? fechaNacimiento) : 
            base(nombre, apellido, dni, fechaNacimiento)
        {
        }
    }
}
