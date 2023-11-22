using Entidades.Archivos;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Clases 
{
    public class Paciente : Persona, IArchivos<Paciente>
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

        public static string RutaArchivo { get => Path.Combine(".\\", "Pacientes.json"); set => RutaArchivo = value; }


        public bool GuardarArchivoJson(List<Paciente> list)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(RutaArchivo))
            {
                string listaJson = JsonSerializer.Serialize(list, options);
                sw.WriteLine(listaJson);
            }
            return true;
        }

        public List<Paciente> CargarArchivoJson()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            using (StreamReader sr = new StreamReader(RutaArchivo))
            {
                string listaJson = sr.ReadToEnd();
                listaPacientes = JsonSerializer.Deserialize<List<Paciente>>(listaJson);
            }
            if (listaPacientes is null)
            {
                throw new NoPudoLeerElArchivoException();
            }
            return listaPacientes;
        }
    }
}
