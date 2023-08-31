using Etec.Estacionamento.Modelos;

namespace TesteEstacionamentoEtec;

public class VeiculoTeste

{
    [Fact]
    public void AcelerarTeste()

    {

        //Arange
        Veiculo veiculo = new Veiculo();

        //Act
        veiculo.Acelerar(10);

        //Assert

        Assert.Equal(100,veiculo.VelocidadeAtual);

    }

    [Fact]
    public void FrearTeste()

    {

        //Arange
        Veiculo veiculo = new Veiculo();

        //Act
        veiculo.Acelerar(15);

        //Assert

        Assert.Equal(150, veiculo.VelocidadeAtual);

    }

}