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
            List<Consulta> consultas = new List<Consulta>
            {
                new Consulta(1, "123", 1, 1),
                new Consulta(2, "123", 2, 2),
                new Consulta(3, "123", 3, 1),
                new Consulta(4, "123", 4, 2)
            };

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
            Assert.AreEqual(10, resultado);
        }


        [TestMethod]
        public void AlInvocarElMetodoGetMaxIdDePaciente_SiTieneDatos_SeObtieneElUltimoIdDeLaLista()
        {
            //Arrange
            List<Consulta> consultas = new List<Consulta>
            {
                new Consulta(1, "123", 1, 1),
                new Consulta(2, "123", 2, 2),
                new Consulta(3, "123", 3, 1),
                new Consulta(4, "123", 4, 2)
            };
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
            //Act
            int resultado = Consulta.PrecioTotalGastado(consultas, practicas);
            //Assert
            Assert.AreEqual(70 , resultado);
        }
    }
}