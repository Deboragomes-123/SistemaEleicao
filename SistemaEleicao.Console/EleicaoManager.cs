using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaEleicao.Console
{
    public class EleicaoManager
    {
        public List<Candidato> Candidatos { get; private set; } = new List<Candidato>();

        public void CadastrarCandidato(string nome, int numero)
        {
            if (Candidatos.Any(c => c.Numero == numero))
            {
                throw new InvalidOperationException("Já existe um candidato cadastrado com este número.");
            }

            Candidatos.Add(new Candidato(nome, numero));
        }
    }
}