using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.SQL
{
    public static class GestorSQL
    {
        internal static string stringConnection;

        static GestorSQL()
        {
            GestorSQL.stringConnection = "Server=.;Database=TP2_2C_2023;Trusted_Connection=True;";
        }
    }
}
