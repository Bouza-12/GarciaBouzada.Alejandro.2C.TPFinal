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

    public class Practica : IArchivos<Practica>
    {
        private static Dictionary<EPracticas, double> practicas;

        private int idPractica;
        private int precio;
        private string practicaNombre;

        static Practica()
        {
            practicas = new Dictionary<EPracticas, double>();
        }
        public Practica()
        {

        }

        public Practica(EPracticas practica, int precio)
        {
            this.practicaNombre = practica.ToString();
            this.precio = precio;
        }

        public string PracticaNombre { get => practicaNombre; set => practicaNombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdPractica { get => idPractica; set => idPractica = value; }
        public string RutaArchivo { get => Path.Combine(".\\", "Practicas.json"); set => RutaArchivo = value; }

        public List<Practica> CargarArchivoJson()
        {
            List<Practica> listaPracticas = new List<Practica>();
            using (StreamReader sr = new StreamReader(RutaArchivo))
            {
                string listaJson = sr.ReadToEnd();
                listaPracticas = JsonSerializer.Deserialize<List<Practica>>(listaJson);
            }
            if (listaPracticas is null)
            {
                throw new NoPudoLeerElArchivoException();
            }
            return listaPracticas;
        }

        public bool GuardarArchivoJson(List<Practica> list)
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
        public override string ToString()
        {
            return $"ID: {this.idPractica} => Practica: {this.practicaNombre}";
        }
        public static int SumarPreciosDeUnaListaDePracticas(List<Practica> lista)
        {
            int sum = 0;
            foreach(Practica p in lista)
            {
                sum += p.Precio;
            }
            return sum;
        }
    }
}
