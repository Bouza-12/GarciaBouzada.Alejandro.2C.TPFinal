namespace Entidades.Clases
{

    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public string NombreCompleto
        {
            get { return $"{Apellido}, {Nombre}"; }
        }
        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.dni = dni;
        }
        public Persona() { }
    }
}