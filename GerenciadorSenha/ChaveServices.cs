using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorSenha
{
    public class ChaveServices
    {
        public List<Chave> Chaves { get; set; }
        public Chave Chave { get; set; }
        public List<string> RetornoMensagem { get; set; }

        readonly string Caminho = Directory.GetParent(Directory.GetCurrentDirectory()) + @"\Data\Senhas\";

        public ChaveServices(List<Chave> chaves) => Chaves = chaves;

        public ChaveServices(Chave chave) => Chave = chave;
        public ChaveServices() { }

        public void Gravar()
        {
            Directory.CreateDirectory(Caminho);
            using StreamWriter sw = new StreamWriter(Caminho + "Senhas");
            Chaves.ForEach(item =>
            {
                sw.WriteLineAsync($"{item.Id}:-{item.Nome}:-{item.Senha}:-{item.Observacao}:-{item.DataCadastro}");
            });
        }

        public async Task<List<Chave>> LerChavesAsync()
        {
            Directory.CreateDirectory(Caminho);

            Chaves = new List<Chave>();

            using StreamReader sr = new StreamReader(Caminho + "Senhas");
            string line = string.Empty;
            while((line = await sr.ReadLineAsync()) != null)
            {
                string[] items = line.Split(":-");

                Chaves.Add(new Chave(int.Parse(items[0]), items[1], items[2], items[3], DateTime.Parse(items[4]), null));  
            }

            return Chaves;
        }
    }
}
