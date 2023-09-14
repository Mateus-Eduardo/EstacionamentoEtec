using Etec.Estacionamento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TesteEstacionamentoEtec
{
    public class PatioTeste
    {
        [Fact]
        public void TestePesquisarVeiculo()
        {
            // Arrange
            Patio estacionamento = new Patio();
            Veiculo veiculo = new Veiculo();
            var veiculos = new List<Veiculo> { veiculo };
            var pesquisaVeiculo = new Veiculo { Placa = "XYZ123", Modelo = "Carro" };

            // Act
            var resultado = estacionamento.PesquisaVeiculo(pesquisaVeiculo.Placa);

            // Assert
            Assert.Equal(veiculo, resultado);
        }
    }
}