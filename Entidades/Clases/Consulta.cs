using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Archivos;
using System.Text.Json;
using Entidades.Excepciones;

namespace Entidades.Clases 
{
    public class Consulta : IArchivos<Consulta>
    {
        private int id;
        private string descripcion;
        private int idPractica;
        private int idPaciente;

        private static string RutaArchivo = Path.Combine(".\\", "Consultas.json");
        public Consulta() { }
        public Consulta(int id, string descripcion, int idPaciente, int idpractica)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.IdPractica = idpractica;
            this.IdPaciente = idPaciente;
        }
        
        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdPractica { get => idPractica; set => idPractica = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }


        string IArchivos<Consulta>.RutaArchivo { get => RutaArchivo; set => RutaArchivo = value; }

        public bool GuardarArchivoJson(List<Consulta> list)
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

        public List<Consulta> CargarArchivoJson()
        {           
            List<Consulta> listaConsultas = new List<Consulta>();
            using (StreamReader sr = new StreamReader(RutaArchivo))
            {
                string listaJson = sr.ReadToEnd();
                listaConsultas = JsonSerializer.Deserialize<List<Consulta>>(listaJson);
            }
            if(listaConsultas is null)
            {
                throw new NoPudoLeerElArchivoException();
            }
            return listaConsultas;
        }

    }
}
