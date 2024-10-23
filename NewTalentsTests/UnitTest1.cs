using NewTalents;

namespace NewTalentsTests;

public class UnitTest1
{
    private Calculadora _calculadora = new Calculadora();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestarSomar(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calculadora.Somar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(8, 5, 3)]
    public void TestarSubtrair(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calculadora.Subtrair(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(8, 5, 40)]
    public void TestarMultiplicar(int num1, int num2, int resultadoEsperado)
    {
        int resultado = _calculadora.Multiplicar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void TestarDividir(int num1, int num2, float resultadoEsperado)
    {
        var resultado = _calculadora.Dividir(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        var calculadoraEspecial = new Calculadora();

        _ = calculadoraEspecial.Somar(1, 2);
        _ = calculadoraEspecial.Multiplicar(4, 5);
        _ = calculadoraEspecial.Dividir(3, 2);

        var resultado = calculadoraEspecial.HistoricoDeResultados(); ;

        Assert.NotEmpty(resultado);
        Assert.Equal(3, resultado.Count);
    }
}
