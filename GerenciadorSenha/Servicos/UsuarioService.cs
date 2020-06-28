using GerenciadorSenha.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorSenha.Servicos
{
    public class UsuarioService : Services
    {
        #region Propriedades
        public List<Usuario> Usuarios { get; set; }
        #endregion

        #region Construtores
        public UsuarioService(string key) : base(key)
        {
        }
        public UsuarioService(List<Usuario> usuarios, string key) : base(key) => Usuarios = usuarios;
        #endregion

        #region Metodos

        private string CaminhoFile => FileService(Modelos.Enum.ServicesEnum.Usuario).FullName;

        public void Gravar()
        {
            BlockDeblockFolder(false);
            using StreamWriter sw = new StreamWriter(CaminhoFile);
            Usuarios.ForEach(async item =>
            {
                string line = $"{item.Id}:-{item.Nome}:-{item.Senha}:-{item.DicaSenha}:-{item.Nascimento}:-{item.Cadastro}";
                await sw.WriteLineAsync(Cripto.Encrypt(line));
            });

            sw.Close();

            BlockDeblockFolder(true);
        }

        public async Task LerAsync()
        {
            Usuarios = new List<Usuario>();

            BlockDeblockFolder(false);

            using StreamReader sr = new StreamReader(CaminhoFile);

            string line = string.Empty;
            int contLine = 0;

            while ((line = await sr.ReadLineAsync()) != null)
            {
                try
                {
                    string[] items = Cripto.Decrypt(line).Split(":-");

                    if (items.Count() >= 6)
                    {
                        Usuarios.Add(new Usuario(int.Parse(items[0]),
                            items[1], items[2], null,
                            items[3], DateTime.Parse(items[4]),
                            DateTime.Parse(items[5]), null, null));
                    }
                    else
                    {
                        RetornoMensagem.Add("Erro na leitura do arquivo de usuarios => Linha " + contLine);
                    }
                }
                catch (Exception)
                {
                    RetornoMensagem.Add("Erro na leitura do arquivo de usuarios => Linha " + contLine);
                }

                contLine++;
            }

            sr.Close();

            BlockDeblockFolder(true);
        }
        #endregion
    }
}
