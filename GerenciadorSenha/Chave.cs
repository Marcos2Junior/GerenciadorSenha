using System;
using System.Collections.Generic;

namespace GerenciadorSenha
{
    public class Chave
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<ChaveVisualiza> ChaveVisualizas { get; set; }

        public Chave()
        {
        }

        public Chave(int id, string nome, string senha, string observacao, DateTime dataCadastro, List<ChaveVisualiza> chaveVisualizas)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Observacao = observacao;
            DataCadastro = dataCadastro;
            ChaveVisualizas = chaveVisualizas;
        }
    }
}
