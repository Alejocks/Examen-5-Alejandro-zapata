namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeberiaCalcularyEncontrarElCampeonConLosPromedios()
        {
            //Inicializar
            int Puntos = 100;
            int Campañas = 10;

            float Esperado = (float)Puntos / Campañas;

            //Utilizamos
            float result = ex03_CampeonDeBarrio.Program.IdentificaCampeon();

            //Validamos
            Assert.AreEqual(Esperado, result);

        }
    }
}