using TestCalculadora;

namespace TestUnitCalculadora
{
    public class UnitTestCalculadora
    {
        [Fact]
        public void Suma_DeberiaRetornarSumaCorrecta()
        {
            // Arrange: Configuración inicial
            int num1 = 5;
            int num2 = 4;
            int resultadoEsperado = 8;

            // Act: Llamada al método que quieres probar


            Calculadora calculadora = new Calculadora();
            int resultadoObtenido = calculadora.Sumar(num1, num2);

            // Assert: Verificación de los resultados
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }
    }
}