using System;
using SistemaEleicao.Console;
using Xunit;

namespace SistemaEleicao.Tests
{
    public class CandidatoTests
    {
        [Fact]
        public void CadastrarCandidato_ComSucesso()
        {
            var manager = new EleicaoManager();

            manager.CadastrarCandidato("Candidato A", 10);

            Assert.Single(manager.Candidatos);
            Assert.Equal("Candidato A", manager.Candidatos[0].Nome);
            Assert.Equal(10, manager.Candidatos[0].Numero);
        }

        [Fact]
        public void CadastrarCandidato_ComNumeroDuplicado_DeveLancarExcecao()
        {
            var manager = new EleicaoManager();
            manager.CadastrarCandidato("Candidato A", 10);

            var ex = Assert.Throws<InvalidOperationException>(() =>
                manager.CadastrarCandidato("Candidato B", 10));

            Assert.Equal("Já existe um candidato cadastrado com este número.", ex.Message);
        }
    }
}