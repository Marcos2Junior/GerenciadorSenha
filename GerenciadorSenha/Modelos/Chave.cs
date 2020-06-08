using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorSenha.Modelos
{
    public class Chave
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Tamanho deve ser entre 5 e 20 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(50, ErrorMessage = "50 caracteres é o maximo permitido.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(50, ErrorMessage = "50 caracteres é o maximo permitido.")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "Senhas não conferem.")]
        public string ConfSenha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Tamanho deve ser entre 10 e 200 caracteres.")]
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<ChaveVisualiza> ChaveVisualizas { get; set; }

        public Chave()
        {
        }

        public Chave(int id, string nome, string senha, string confSenha, string observacao, DateTime dataCadastro, List<ChaveVisualiza> chaveVisualizas)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            ConfSenha = confSenha;
            Observacao = observacao;
            DataCadastro = dataCadastro;
            ChaveVisualizas = chaveVisualizas;
        }
    }
}
