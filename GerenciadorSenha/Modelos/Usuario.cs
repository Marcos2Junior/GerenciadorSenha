using System;
using System.Collections.Generic;

namespace GerenciadorSenha.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string DicaSenha { get; set; }
        public DateTime Nascimento { get; set; }
        public List<Chave> Chaves { get; set; }
        public List<UsuarioAcesso> UsuarioAcessos { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nome, string senha, string dicaSenha, DateTime nascimento, List<Chave> chaves, List<UsuarioAcesso> usuarioAcessos)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            DicaSenha = dicaSenha;
            Nascimento = nascimento;
            Chaves = chaves;
            UsuarioAcessos = usuarioAcessos;
        }
    }
}
