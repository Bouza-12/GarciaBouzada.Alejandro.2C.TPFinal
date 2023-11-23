using Entidades.Clases;

namespace MSTests
{
    [TestClass]
    public class TestDeClases
    {
        [TestMethod]
        public void AlInvocarElMetodoPrecioTotalGastadoPorPersonaPorId_SiTieneLosDatos_DeberiaObtenerElTotalDeLaSuma()
        {
            //Arrange
            List<Consulta> consultas = new List<Consulta>();
            consultas.Add(new Consulta(1, "123", 1, 1));
            consultas.Add(new Consulta(2, "123", 2, 2));
            consultas.Add(new Consulta(3, "123", 3, 1));
            consultas.Add(new Consulta(4, "123", 4, 2));

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

            int id = 1;

            //Act
            int resultado = Consulta.PrecioTotalGastadoPorPersonaPorId(consultas, practicas, id);

            //Asert
            Assert.Equals(10, resultado);
        }
    }
}