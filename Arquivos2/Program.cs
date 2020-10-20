using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivos2
{
    class Program
    {
        static void Main(string[] args)
        {

            //windows
            //string sourcePath = "c:\\temp\\arquivotexto.txt";
            //ou
            //string sourcePath = @"c:\temp\arquivotexto.txt";

            //mac
            // diretorio padrao '/Users/nxgames/Arquivos2/Arquivos2/Projeto1/bin/Debug/netcoreapp3.1/arquivotexto.txt

            /* VERSAO 1 sem o BLOCO USING
            string path = "/Users/nxgames/Projects/Arquivos2/Arquivos2/arquivotexto.txt";


            //FileStream   fs = null;
            StreamReader sr = null;

             
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);

                //ou mais direto, abrindo mao do objeto STREAMREADER,
                //pois a classe FILE estancia para mim o filestream e o streamreder para mim
                sr = File.OpenText(path);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    Console.WriteLine(line);

                }
            }

            catch (IOException e)
            {
                Console.WriteLine("ERRO (IO): " + e.Message);

            }

            finally
            {
                //vou ter que fechar os arquivos independente de erro ou nao
                Console.WriteLine("FECHANDO O ARQUIVO: " + path);

                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();

            }
            */

            /*
            //versao com o BLOCO USING
            string path = "/Users/nxgames/Projects/Arquivos2/Arquivos2/arquivotexto.txt";

            try
            {
                //tudo estanciado neste bloco USING e ao final ele será fechado
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            Console.WriteLine(line);

                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO (IO): " + e.Message);

            }
            */

            /*
            //versao com o BLOCO USING... estanciando o StreamReader de forma resumida, apenas com a classe File
            string path = "/Users/nxgames/Projects/Arquivos2/Arquivos2/arquivotexto.txt";

            try
            {
                //tudo estanciado neste bloco USING e ao final ele será fechado
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        Console.WriteLine(line);

                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO (IO): " + e.Message);

            }
            */

            /*

            //Agora vamos usar o StreamWriter em ver do StreamReader

            string sourcePath = "/Users/nxgames/Projects/Arquivos2/Arquivos2/arquivotexto.txt";
            string targetpath = "/Users/nxgames/Projects/Arquivos2/Arquivos2/arquivotexto2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());

                    }

                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO (IO): " + e.Message);

            }

            */


            /*
            // DIRETCTORY E DIRECTORYINFO
            //no windows
            //string path = @"c:\temp\myfolder";
            //string path = "c:\\temp\\myfolder";

            string path = "/Users/nxgames/Projects/Arquivos2/Arquivos2/myfolder";

            try
            {
                
                //usando só var tb dá, daí o C# faz a inferência do tipo para nós
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                //mas prefiro declarar...
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders: ");

                foreach(string pastas in folders)
                {
                    Console.WriteLine(pastas);

                }


                //mas prefiro declarar...
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files: ");

                foreach (string pastas in files)
                {
                    Console.WriteLine(pastas);

                }

                //para o windows

                // Directory.CreateDirectory(path + "\\newfolder");
                // Directory.CreateDirectory(path + @"\newfolder");

                Directory.CreateDirectory(path + "/newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO (IO): " + e.Message);

            }
            */

            //windows
            //string path = @"c:\temp\myfolder\file1.txt";

            string path = "/Users/nxgames/Projects/Arquivos2/Arquivos2/myfolder/file1.txt";


            //sistema baseado em linux (unix)
            Console.WriteLine("DirectorySeparatorChar......: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator...............: " + Path.PathSeparator);

            //: "os dois pontos" é o caracter para separar as pastas, no windows é o ; "ponto e virgual;

            Console.WriteLine("GetDirectoryName............: " + Path.GetDirectoryName(path));
            Console.WriteLine();
          
            Console.WriteLine("GetFullPath.................: " + Path.GetFullPath(path));
            Console.WriteLine();

            Console.WriteLine("GetFileName.................: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension.: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension................: " + Path.GetExtension(path));
            Console.WriteLine();

            //Pasta temporária do sistema onde eu posso manipular alteracoes
            Console.WriteLine("GetTempPath................: " + Path.GetTempPath());
            Console.WriteLine();

        }
    }
}
