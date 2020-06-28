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
            DirectoryInfo = new DirectoryInfo(
                new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\Data.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\");

            RetornoMensagem = new List<string>();
        }
        #endregion

        #region Metodos
        protected FileInfo FileService(ServicesEnum servicesEnum)
        {
            string _path = DirectoryInfo.FullName + servicesEnum + ".gercrip";

            if (!File.Exists(_path))
                File.Create(_path).Close();

            return new FileInfo(_path);
        }

        /// <summary>
        /// Bloqueia/Libera acesso a pasta Data
        /// </summary>
        /// <param name="block">true para bloquear</param>
        protected void BlockDeblockFolder(bool block)
        {
            bool checkBlock;

            do
            {
                try
                {
                    DirectoryInfo.Attributes = FileAttributes.Normal;
                    Directory.CreateDirectory(DirectoryInfo.FullName);
                    string newPathDirectory;
                    if (DirectoryInfo.FullName.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
                    {
                        newPathDirectory = DirectoryInfo.FullName.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "");
                        Directory.Move(DirectoryInfo.FullName, newPathDirectory);
                        checkBlock = false;
                    }
                    else
                    {
                        newPathDirectory = DirectoryInfo.FullName.Replace(DirectoryInfo.Name, DirectoryInfo.Name + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");
                        Directory.Move(DirectoryInfo.FullName, newPathDirectory);
                        checkBlock = true;
                    }

                    DirectoryInfo = new DirectoryInfo(newPathDirectory) { Attributes = FileAttributes.Hidden };
                }
                catch (IOException ioException)
                {
                    throw ioException;
                }

            } while (checkBlock != block);
        }

        #endregion
    }
}
