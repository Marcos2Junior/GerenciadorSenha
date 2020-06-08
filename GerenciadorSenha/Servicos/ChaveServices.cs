using GerenciadorSenha.Classes;
using GerenciadorSenha.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSenha.Servicos
{
    public class ChaveServices
    {
        private List<Chave> Chaves;
        private Chave Chave;
        private readonly Cripto Cripto;
        public List<string> RetornoMensagem { get; set; }
        
        private readonly string Caminho = Directory.GetParent(Directory.GetCurrentDirectory()) + @"\Data\Senhas\";


        public ChaveServices(List<Chave> chaves, string key)
        {
            Chaves = chaves;
            Cripto = new Cripto(key);
        }

        public ChaveServices(Chave chave, string key)
        {
            Chave = chave;
            Cripto = new Cripto(key);
        }
        public ChaveServices(string key) => Cripto = new Cripto(key);

        public void Gravar()
        {


            Directory.CreateDirectory(Caminho);
            using StreamWriter sw = new StreamWriter(Caminho + "Senhas");
            Chaves.ForEach(item =>
            {
                sw.WriteLineAsync($"{item.Id}:-{item.Nome}:-{Cripto.Encrypt(item.Senha)}:-{item.Observacao}:-{item.DataCadastro}");
            });
        }

        public async Task<List<Chave>> LerChavesAsync()
        {
            Directory.CreateDirectory(Caminho);

            Chaves = new List<Chave>();

            if (File.Exists(Caminho + "Senhas"))
            {
                using StreamReader sr = new StreamReader(Caminho + "Senhas");

                string line = string.Empty;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    string[] items = line.Split(":-");

                    Chaves.Add(new Chave(int.Parse(items[0]), items[1], Cripto.Decrypt(items[2]), items[3], DateTime.Parse(items[4]), null));
                }
            }

            return Chaves;
        }
    }
}
