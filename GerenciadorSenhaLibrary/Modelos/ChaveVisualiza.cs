using System;

namespace GerenciadorSenhaLibrary.Modelos
{
    public class ChaveVisualiza
    {
        public Chave Chave { get; set; }
        public DateTime DataVisualizada { get; set; }

        public ChaveVisualiza(Chave chave, DateTime dataVisualizada)
        {
            Chave = chave;
            DataVisualizada = dataVisualizada;
        }
    }
}