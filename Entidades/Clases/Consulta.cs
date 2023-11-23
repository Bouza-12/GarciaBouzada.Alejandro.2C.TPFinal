using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Archivos;
using System.Text.Json;
using Entidades.Excepciones;
using Entidades.Extensiones;

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
        public Consulta(string descripcion, int idPaciente, int idpractica)
        {
            this.Descripcion = descripcion;
            this.IdPractica = idpractica;
            this.IdPaciente = idPaciente;
        }
        public Consulta(int id, string descripcion, int idPaciente, int idpractica) : this(descripcion, idPaciente, idpractica)
        {
            this.Id = id;
        }
        
        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdPractica { get => idPractica; set => idPractica = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }


        string IArchivos<Consulta>.RutaArchivo { get => RutaArchivo; set => RutaArchivo = value; }

        /// <summary>
        /// Guarda una lista de Consulta en Formato Json
        /// </summary>
        /// <param name="list">Lista tipo Consulta a guardar en archivo</param>
        /// <returns>true si pudo guardar el archivo</returns>
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

        /// <summary>
        /// Genera una Lista de Consulta a partir de un archivo Json - El archivo debe estar dentro de la carpeta determinada
        /// </summary>
        /// <returns>Lista de tipo Consulta con los registros del archivo .Json</returns>
        /// <exception cref="NoPudoLeerElArchivoException"></exception>
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


        public override string ToString()
        {
            return $"ID: {id} => Descripcion: {this.Descripcion}";
        }
        /// <summary>
        /// Devuelve el total gastado por un IdPaciente
        /// </summary>
        /// <param name="list"></param> Lista de Consultas
        /// <param name="practicas"></param> Lista de Prácticas
        /// <param name="idPaciente"></param> Paciente que se quiere buscar
        /// <returns>La suma de los precios asociados a las practicas por ese id</returns>
        public static int PrecioTotalGastadoPorPersonaPorId(List<Consulta> list,List<Practica> practicas ,int idPaciente)
        {
            int suma = 0;
            if(list is not null)
            {
                foreach(Consulta c in list)
                {
                    if(c.idPaciente == idPaciente)
                    {
                        foreach (Practica p in practicas)
                        {
                            if (c.idPractica == p.IdPractica)
                            {
                                suma += p.Precio;
                            }
                        }
                    }
                }
            }
            return suma;
        }
        /// <summary>
        /// Suma de los precios de la Practicas de todas las consultas
        /// </summary>
        /// <param name="list">lista de tipo Consulta</param>
        /// <param name="practicas"> lista de tipo Practica</param>
        /// <returns>La suma</returns>
        public static int PrecioTotalGastado(List<Consulta> list, List<Practica> practicas)
        {
            int suma = 0;
            if (list is not null)
            {
                foreach (Consulta c in list)
                {
                    foreach (Practica p in practicas)
                    {
                        if (c.idPractica == p.IdPractica)
                        {
                            suma += p.Precio;
                        }
                    }
                }
            }
            return suma;
        }
        /// <summary>
        /// Guarda una lista de Consulta en Formato Json
        /// </summary>
        /// <param name="list">Lista tipo Consulta a guardar en archivo</param>
        /// <returns>true si pudo guardar el archivo</returns>
        public static bool GuardarEnArchivoJson(List<Consulta> list)
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

    }
}
