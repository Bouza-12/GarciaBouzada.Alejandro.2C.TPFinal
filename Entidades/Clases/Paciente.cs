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

        public string RutaArchivo { get => Path.Combine(".\\", "Pacientes.json"); set => RutaArchivo = value; }
        private static string RutaDelArchivo = Path.Combine(".\\", "Pacientes.json");

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

        public static bool ExistePacientePorDni(List<Paciente> list, int dni)
        {
            foreach(Paciente p in list)
            {
                if(p.DNI == dni)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Guarda una lista de Paciente en Formato Json
        /// </summary>
        /// <param name="list">Lista tipo Paciente a guardar en archivo</param>
        /// <returns>true si pudo guardar el archivo</returns>
        public static bool GuardarEnArchivoJson(List<Paciente> list)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(RutaDelArchivo))
            {
                string listaJson = JsonSerializer.Serialize(list, options);
                sw.WriteLine(listaJson);
            }
            return true;
        }
    }
}
