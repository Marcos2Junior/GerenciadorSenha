using System;

namespace GerenciadorSenhaLibrary.Modelos
{
    public class UsuarioAcesso
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataAcesso { get; set; }
        public DateTime? DataSaida { get; set; }

        public UsuarioAcesso()
        {
        }

        public UsuarioAcesso(int id, Usuario usuario, DateTime dataAcesso, DateTime? dataSaida)
        {
            Id = id;
            Usuario = usuario;
            DataAcesso = dataAcesso;
            DataSaida = dataSaida;
        }
    }
}
