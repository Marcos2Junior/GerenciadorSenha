using GerenciadorSenha.Classes;
using GerenciadorSenha.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorSenha.Servicos
{
    public class ChaveServices : Services
    {
        #region Variaveis

        #endregion

        #region Propriedades
        public List<Chave> Chaves { get; set; }
        #endregion

        #region Construtores
        public ChaveServices(List<Chave> chaves, string key) : base(key) => Chaves = chaves;
        public ChaveServices(string key) : base(key)
        {
        }
        #endregion

        #region Metodos

        private string CaminhoFile => FileService(Modelos.Enum.ServicesEnum.Chave).FullName;

        public async Task LerChavesAsync()
        {
            Chaves = new List<Chave>();

            BlockDeblockFolder(false);

            using StreamReader sr = new StreamReader(CaminhoFile);

            string line = string.Empty;
            int contline = 0;
            while ((line = await sr.ReadLineAsync()) != null)
            {
                try
                {
                    string[] items = Cripto.Decrypt(line).Split(":-");

                    if (items.Count() >= 5)
                        Chaves.Add(new Chave(int.Parse(items[0]), items[1], items[2], string.Empty, items[3], DateTime.Parse(items[4]), null));
                    else
                        RetornoMensagem.Add("Erro na leitura do arquivo de usuarios => Linha " + contline);
                }
                catch (Exception)
                {
                    RetornoMensagem.Add("Erro na leitura do arquivo de usuarios => Linha " + contline);
                }

                contline++;
            }

            sr.Close();

            BlockDeblockFolder(true);

        }
        public void Gravar()
        {
            BlockDeblockFolder(false);
            using StreamWriter sw = new StreamWriter(CaminhoFile);
            Chaves.ForEach(item =>
            {
                string line = $"{item.Id}:-{item.Nome}:-{item.Senha}:-{item.Observacao}:-{item.DataCadastro}";
                sw.WriteLineAsync(Cripto.Encrypt(line));
            });
            sw.Close();

            BlockDeblockFolder(true);
        }

        #endregion
    }
}
