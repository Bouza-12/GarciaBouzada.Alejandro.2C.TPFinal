using Entidades.Clases;
using Entidades.SQL;
using System.Collections.Concurrent;
using System.IO;
using System.Text.Json;
using System.Transactions;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paciente paciente = SQLPaciente.ObtenerPacientePorId(5);
            //Console.WriteLine(paciente);
            //List<Paciente> pacientes = SQLPaciente.ObtenerTodasLosPacientes();
            //foreach (Paciente p in pacientes)
            //{
            //    Console.WriteLine(p);
            //}
            //Paciente paciente2 = new Paciente("Alexander", "Cage", 30629584, new DateTime(1985, 02, 12));
            //if (SQLPaciente.AgregarPaciente(paciente2))
            //{
            //    Paciente p = SQLPaciente.ObtenerPacientePorId(40);
            //    Console.WriteLine(p);
            //}
            //if (SQLPaciente.BorrarPaciente(51))
            //{
            //    List<Paciente> pacientes2 = SQLPaciente.ObtenerTodasLosPacientes();
            //    foreach (Paciente p in pacientes2)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}

            //Consulta consulta = SQLConsulta.ObtenerConsultaPorId(20);
            //Console.WriteLine(consulta);
            //Consulta nuevaConsulta = new Consulta(103, "Cualquiera", 22, 4);
            //SQLConsulta.AgregarConsulta(nuevaConsulta);
            //List<Consulta> listaConsultas = SQLConsulta.ObtenerTodasLasConsutlas();
            //foreach(Consulta c in listaConsultas)
            //{
            //    Console.WriteLine(c);
            //}

            //Practica practica = SQLPractica.ObtenerPracticaPorId(6);
            //Console.WriteLine(practica);
            //List<Practica> listaPracticas = SQLPractica.ObtenerTodasLasPracticas();
            //foreach (Practica p in listaPracticas)
            //{
            //    Console.WriteLine(p);
            //}


            //    string nombreCarpeta = "Archivos";
            //    string rutaArchivos = Path.Combine(@".\", nombreCarpeta);

            //    if (!Directory.Exists(rutaArchivos))
            //    {
            //        Directory.CreateDirectory(rutaArchivos);
            //    }
            //    string nombreArchivo = "ArchivoTest.txt";
            //    string rutaCompleta = Path.Combine(rutaArchivos, nombreArchivo);

            //    using( StreamWriter sw = new StreamWriter(rutaCompleta))
            //    {
            //        sw.WriteLine("Esto es una prueba");
            //    }
            //    using (StreamWriter sw = new StreamWriter(rutaCompleta, true))
            //    {
            //        sw.WriteLine("Esto es una prueba que puede apendear");
            //    }

            //    using (StreamReader sr = new StreamReader(rutaCompleta))
            //    {
            //        string linea = "";
            //        while(linea is not null)
            //        {
            //            linea = sr.ReadLine();
            //            Console.WriteLine(linea);
            //        }
            //    }

            //    Consulta c1 = new Consulta(1,"uno",1,1);
            //    Consulta c2 = new Consulta(2,"dos",2,2);
            //    List<Consulta> consultas = new List<Consulta>();
            //    consultas.Add(c1);
            //    consultas.Add(c2);

            //    string nuevaRutaJson = Path.Combine(rutaArchivos, "ArchivoJson.json");
            //    JsonSerializerOptions options = new JsonSerializerOptions();
            //    options.WriteIndented = true;

            //    using(StreamWriter sw = new StreamWriter(nuevaRutaJson))
            //    {


            //            string listaJson = JsonSerializer.Serialize(consultas,options);
            //            sw.WriteLine(listaJson);

            //    }

            //    List<Consulta> cons = new List<Consulta>();
            //    using (StreamReader sr = new StreamReader(nuevaRutaJson))
            //    {
            //        string listaJson = sr.ReadToEnd();
            //        cons = JsonSerializer.Deserialize<List<Consulta>>(listaJson);
            //    }

            //    foreach (Consulta c in cons)
            //    {
            //        Console.WriteLine($"{c.Id} , {c.Descripcion}");
            //        Console.WriteLine("************************");
            //    }

            //Arrange
            List<Consulta> consultas = new List<Consulta>();
            consultas.Add(new Consulta(1, "123", 1, 1));
            consultas.Add(new Consulta(2, "123", 2, 2));
            consultas.Add(new Consulta(3, "123", 3, 1));
            consultas.Add(new Consulta(4, "123", 1, 2));

            List<Practica> practicas = new List<Practica>();
            Practica p1 = new Practica();
            p1.IdPractica = 1;
            p1.PracticaNombre = "1";
            p1.Precio = 10;
            Practica p2 = new Practica();
            p2.IdPractica = 2;
            p2.PracticaNombre = "2";
            p2.Precio = 25;
            practicas.Add(p1);
            practicas.Add(p2);

            int id = 2;

            int resultado = Consulta.PrecioTotalGastadoPorPersonaPorId(consultas, practicas, id);

            Console.WriteLine($"{resultado.ToString()}");

        }
    }
}