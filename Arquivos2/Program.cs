using System;
using System.IO;

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
        }
    }
}
