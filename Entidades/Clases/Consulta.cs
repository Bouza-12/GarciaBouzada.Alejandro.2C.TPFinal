using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Consulta
    {
        private int id;
        private string descripcion;
        private int idPractica;
        private int idPaciente;

        public Consulta(int id, string descripcion, int idPaciente, int idpractica)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.IdPractica = idpractica;
            this.IdPaciente = idPaciente;
        }
        public Consulta() { }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdPractica { get => idPractica; set => idPractica = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
    }
}
