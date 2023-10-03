using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes() => _calc = new CalculadoraImp();

    /*[Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }*/
    [Fact]
    public void DeveSomarVariosNumeros()
    {
        //Arrange
        List<int> numeros = new List<int>{1, 3, 4, 5, 8, 7, 9, 9, 10, 102, 58, 98, 65};

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            for (int j = i + 1; j < numeros.Count; j++)
            {
                //Act
                int resultado = _calc.Somar(numeros[i], numeros[j]);

                //Assert
                Assert.Equal(numeros[i] + numeros[j], resultado);
            }
        }
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int num = 4;
        //Act
        bool resultado = _calc.EhPar(num);
        //Assert
        Assert.True(resultado);

    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act - Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));   
    }
}

