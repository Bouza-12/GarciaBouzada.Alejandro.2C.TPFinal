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
        public static Practica ObtenerPracticaPorId(int id)
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
                        p.Precio = (int)reader.GetDouble(2);
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
        public static List<Practica> ObtenerTodasLasPracticas()
        {
            try
            {
                List<Practica> practicas = new List<Practica>();
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "SELECT * FROM Practicas";
                    SqlCommand command = new SqlCommand(query, connection);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Practica p = new Practica();
                            p.IdPractica = reader.GetInt32(0);
                            p.PracticaNombre = reader.GetString(1);
                            p.Precio = (int)reader.GetDouble(2);
                            practicas.Add(p);
                        }
                    }
                    else
                    {
                        throw new ErrorEnConcexionSQLException("No encontro Practica");
                    }

                }
                return practicas;
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error en la conexion a la Base de datos", ex);
            }
        }

        public static bool AgregarPracticas(Practica practica)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "INSERT INTO Practicas (practica, precio)" +
                        "values(@nombre, @precio)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", practica.PracticaNombre);
                    command.Parameters.AddWithValue("precio", practica.Precio);
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
        public static bool BorrarPracticasPorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "DELETE FROM Practicas WHERE idPractica = @id";
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
        public static bool EditarPracticaPorId(Practica practica, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "UPDATE Pacientes set practica= @nombre, precio = @precio WHERE idPractica = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nombre", practica.PracticaNombre);
                    command.Parameters.AddWithValue("precio", practica.Precio);
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
