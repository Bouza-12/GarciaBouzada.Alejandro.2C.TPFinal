namespace Entidades
{

    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime? fechaNacimiento;

        public string NombreCompleto
        {
            get { return $"{apellido}, {nombre}" ; }
        }
        public string DNI 
        {
            get { return dni.ToString(); }
        }
        public int Edad
        {
            get
            {
                if(fechaNacimiento is not null)
                {
                    DateTime hoy = DateTime.Now;
                    int edad =  hoy.Year - fechaNacimiento.Value.Year;
                    if (hoy.Month > fechaNacimiento.Value.Month || 
                        (hoy.Month == fechaNacimiento.Value.Month && hoy.Day > fechaNacimiento.Value.Day))
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


        public Persona(string nombre, string apellido, int dni, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}