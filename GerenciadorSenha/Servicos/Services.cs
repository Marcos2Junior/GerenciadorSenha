using GerenciadorSenha.Classes;
using System.Collections.Generic;
using System.IO;

namespace GerenciadorSenha
{
    public abstract class Services
    {
        #region Variaveis
        protected readonly Cripto Cripto;
        #endregion

        #region Propriedades
        protected DirectoryInfo DirectoryInfo { get; set; }
        public List<string> RetornoMensagem { get; set; }
        #endregion

        #region Construtores
        public Services(string key)
        {
            Cripto = new Cripto(key);
            DirectoryInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            RetornoMensagem = new List<string>();
        }
        #endregion

        #region Metodos
        public bool VerificaExistencia(string caminho) => File.Exists(caminho);
        public void CriaDiretorio() => Directory.CreateDirectory(DirectoryInfo.FullName);
        #endregion
    }
}
