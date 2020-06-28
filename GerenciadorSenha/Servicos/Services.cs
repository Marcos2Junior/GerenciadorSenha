using GerenciadorSenha.Classes;
using GerenciadorSenha.Modelos.Enum;
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
            RetornoMensagem = new List<string>();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Para cada Service é destinado uma fileinfo com o nome do enum Service
        /// </summary>
        /// <param name="servicesEnum">Enum Service</param>
        /// <returns>FileInfo Service</returns>
        protected FileInfo FileService(ServicesEnum servicesEnum)
        {
            string _path = DirectoryInfo.FullName + servicesEnum + ".gercrip";

            if (!File.Exists(_path))
                File.Create(_path).Close();

            return new FileInfo(_path);
        }

        /// <summary>
        /// Bloqueia/Libera acesso a pasta DataInfoApplication
        /// </summary>
        /// <param name="block">true para bloqueio</param>
        protected void BlockDeblockFolder(bool block)
        {
            try
            {
                VerificaDiretorio();

                bool compblock;
                do
                {
                    string newPathDirectory;

                    //libera acesso
                    if (DirectoryInfo.FullName.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
                    {
                        newPathDirectory = DirectoryInfo.FullName.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "");
                        Directory.Move(DirectoryInfo.FullName, newPathDirectory);
                        compblock = false;
                    }
                    //bloqueia acesso
                    else
                    {
                        newPathDirectory = DirectoryInfo.FullName.Replace(DirectoryInfo.Name, DirectoryInfo.Name + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");
                        Directory.Move(DirectoryInfo.FullName, newPathDirectory);
                        compblock = true;
                    }

                    DirectoryInfo = new DirectoryInfo(newPathDirectory);

                    //Garante que o acesso ao diretorio esteja conforme esperado caso a aplicacao tenha sido encerrada no meio do processo
                } while (!block.Equals(compblock));
            }
            catch
            {
                //Planejar um sistema de backup e chamar caso não seja possivel encontrar diretorio atual
            }
        }

        /// <summary>
        /// seleciona Propriedade DirectoryInfo de acordo com o estado atual do diretorio de dados
        /// </summary>
        private void VerificaDiretorio()
        {
            //Diretorio padrao aberto
            DirectoryInfo open = new DirectoryInfo(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\DataInfoApplication\");

            //Diretorio padrao Fechado
            DirectoryInfo block = new DirectoryInfo(open.FullName.Replace(open.Name, open.Name + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"));

            //Propriedade recebe condicao de existencia entre os dois diretorios
            DirectoryInfo = Directory.Exists(open.FullName) ? open : block;

            Directory.CreateDirectory(DirectoryInfo.FullName);
        }

        #endregion
    }
}
