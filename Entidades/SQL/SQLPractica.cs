using Entidades.Clases;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class SQLPractica
    {
        public static Practica ObtenerPrácticaPorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "SELECT * FROM Practicas WHERE idPractica= @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Practica p = new Practica ();
                        p.IdPractica = reader.GetInt32(0);
                        p.PracticaNombre = reader.GetString(1);
                        p.Precio = reader.GetInt32(2);
                        return p;
                    }
                    else
                    {
                        throw new ErrorEnConcexionSQLException("No encontro Paciente");
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error en la conexion a la Base de datos", ex);
            }
        }

        public static List<Paciente> ObtenerTodasLosPacientes()
        {
            try
            {
                List<Paciente> pacientes = new List<Paciente>();
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "SELECT * FROM Pacientes;";
                    SqlCommand command = new SqlCommand(query, connection);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Paciente p = new Paciente();
                            p.IDPaciente = reader.GetInt32(0);
                            p.Nombre = reader.GetString(1);
                            p.Apellido = reader.GetString(2);
                            p.DNI = reader.GetInt32(3);
                            p.FechaNacimiento = reader.GetDateTime(4);
                            pacientes.Add(p);
                        }
                    }
                    else
                    {
                        throw new ErrorEnConcexionSQLException("No encontro Paciente");
                    }

                }
                return pacientes;
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error en la conexion a la Base de datos", ex);
            }
        }

        public static bool AgregarPaciente(Paciente paciente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "INSERT INTO Pacientes (nombre, apellido, dni, fechaNacimiento)" +
                        "values(@nombre, @apellido, @dni, @fechaNac)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", paciente.Nombre);
                    command.Parameters.AddWithValue("apellido", paciente.Apellido);
                    command.Parameters.AddWithValue("dni", paciente.DNI);
                    command.Parameters.AddWithValue("fechaNac", paciente.FechaNacimiento);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error, no se pudo agregar", ex);
            }
        }
        public static bool BorrarPaciente(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "DELETE FROM Pacientes WHERE idPaciente = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error, no se pudo borrar", ex);
            }
        }
        public static bool EditarPaciente(Paciente paciente,int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "UPDATE Pacientes set nombre= @nombre, apellido = @apellido, dni = @dni, fechaNacimiento = @fechaNac WHERE idPaciente = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nombre", paciente.Nombre);
                    command.Parameters.AddWithValue("apellido", paciente.Apellido);
                    command.Parameters.AddWithValue("dni", paciente.DNI);
                    command.Parameters.AddWithValue("fechaNac", paciente.FechaNacimiento);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error, no se pudo editar la persona", ex);
            }
        }
    }
}
