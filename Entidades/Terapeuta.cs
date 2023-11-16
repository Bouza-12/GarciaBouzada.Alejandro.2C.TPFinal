using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Terapeuta : Persona
    {
        List<EPracticas> practicasHabilitadas;
        private string usuario;
        private string contrasenia;
        private int id;

        private static int maxId;
        private static int NewId
        {
            get 
            {
                maxId++ ;
                return maxId; 
            }
        }

        public Terapeuta(int id,string nombre, string apellido, int dni, DateTime? fechaNacimiento, string usuario, string contrasenia) : base(nombre, apellido, dni, fechaNacimiento)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            practicasHabilitadas = new List<EPracticas>();
        }
        public Terapeuta(int id, string nombre, string apellido, int dni, DateTime? fechaNacimiento) : 
            this(id, nombre, apellido, dni, fechaNacimiento, NewId.ToString(), "Contra321")
        {

        }

    }
}
