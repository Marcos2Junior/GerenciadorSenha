using GerenciadorSenha.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorSenha.Servicos
{
    public class ChaveVisualizaServices : Services
    {
        public List<ChaveVisualiza> ChaveVisualizas { get; set; }
        public ChaveVisualizaServices(string key) : base(key)
        {
        }

        #region Metodos

        private string CaminhoFile => FileService(Modelos.Enum.ServicesEnum.ChaveVisualiza).FullName;

        public async Task LerChavesAsync()
        {
            ChaveVisualizas = new List<ChaveVisualiza>();

            BlockDeblockFolder(false);

            using StreamReader sr = new StreamReader(CaminhoFile);

            string line = string.Empty;
            int contline = 0;
            while ((line = await sr.ReadLineAsync()) != null)
            {
                try
                {
                    string[] items = Cripto.Decrypt(line).Split(":-");

                    if (items.Count() >= 2)
                        ChaveVisualizas.Add(new ChaveVisualiza(new Chave { Id = int.Parse(items[0]) }, DateTime.Parse(items[1])));
                    else
                        RetornoMensagem.Add("Erro na leitura do arquivo de ChaveVisualiza => Linha " + contline);
                }
                catch (Exception)
                {
                    RetornoMensagem.Add("Erro na leitura do arquivo de ChaveVisualiza => Linha " + contline);
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
            ChaveVisualizas.ForEach(async item =>
            {
                string line = $"{item.Chave.Id}:-{item.DataVisualizada}";
                await sw.WriteLineAsync(Cripto.Encrypt(line));
            });

            sw.Close();

            BlockDeblockFolder(true);
        }

        #endregion

    }
}
