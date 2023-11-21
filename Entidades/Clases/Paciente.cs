using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Paciente : Persona
    {
        private int idPaciente;
        private DateTime? fechaNacimiento;

        public int IDPaciente
        {
            get { return idPaciente; }
            set { this.idPaciente = value; }
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento.Value;
            set => fechaNacimiento = value;
        }


        public int Edad
        {
            get
            {
                if (fechaNacimiento is not null)
                {
                    DateTime hoy = DateTime.Now;
                    int edad = hoy.Year - fechaNacimiento.Value.Year;
                    if (hoy.Month > fechaNacimiento.Value.Month ||
                        hoy.Month == fechaNacimiento.Value.Month && hoy.Day > fechaNacimiento.Value.Day)
                    {
                        edad--;
                    }
                    return edad;

                }
                else
                {
                    return 0;
                }
            }
        }
        public Paciente () : base()
        {

        }
        public Paciente(string nombre, string apellido, int dni, DateTime? fechaNacimiento) :
            base(nombre, apellido, dni)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return $"ID: {this.idPaciente} => {this.NombreCompleto}, Edad: {this.Edad}";
        }
    }
}
