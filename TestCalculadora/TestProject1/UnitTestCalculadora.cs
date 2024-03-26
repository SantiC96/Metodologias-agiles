using TestCalculadora;

namespace TestUnitCalculadora
{
    public class UnitTestCalculadora
    {
        [Fact]
        public void Suma_DeberiaRetornarSumaCorrecta()
        {
            // Arrange: Configuraci�n inicial
            int num1 = 5;
            int num2 = 4;
            int resultadoEsperado = 8;

            // Act: Llamada al m�todo que quieres probar


            Calculadora calculadora = new Calculadora();
            int resultadoObtenido = calculadora.Sumar(num1, num2);

            // Assert: Verificaci�n de los resultados
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }
    }
}