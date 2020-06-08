using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorSenha.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Tamanho deve ser entre 10 e 100 caracteres.")]
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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Tamanho deve ser entre 10 e 100 caracteres.")]
        public string DicaSenha { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obrigatório.")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        public DateTime Cadastro { get; set; }
        public List<Chave> Chaves { get; set; }
        public List<UsuarioAcesso> UsuarioAcessos { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nome, string senha, string confSenha, string dicaSenha, DateTime nascimento, DateTime cadastro, List<Chave> chaves, List<UsuarioAcesso> usuarioAcessos)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            ConfSenha = confSenha;
            DicaSenha = dicaSenha;
            Nascimento = nascimento;
            Cadastro = cadastro;
            Chaves = chaves;
            UsuarioAcessos = usuarioAcessos;
        }
    }
}
