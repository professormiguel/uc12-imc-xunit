namespace imc_xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double = imc_previsto = 31.25;
        IMC i = new IMC();

        i.peso = 80;
        i.altura = 1.60;

        i.Calcular_IMC();

        Assert.Equal(i.imc, imc_previsto); 
    }
}