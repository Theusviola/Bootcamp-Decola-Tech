using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private Calculadoraimp _calc;

    public CalculadoraTestes()
    {
        _calc = new Calculadoraimp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
}