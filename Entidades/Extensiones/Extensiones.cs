using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Extensiones
{
    public static class Extensiones
    {
        private static int DevolverPrecioParaElId(this Int32 suma, List<Practica> practicas, int id)
        {
            
            if(practicas is not null)
            {
                foreach (Practica p in practicas)
                {
                    if (id == p.IdPractica)
                    {
                        suma += p.Precio;
                    }
                }
            }
            return suma;
        }

    }
}
