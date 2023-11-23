using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IArchivos<T> where T : class
    {
        

        string RutaArchivo { get; set; }
        public bool GuardarArchivoJson(List<T> list);
        public List<T> CargarArchivoJson();

    }
}
