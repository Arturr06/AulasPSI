using System;
using System.IO;
using System.IO.Compression;

namespace Descompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            bool g = false;
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktop, "File.txt.gz");
            string filePath2 = Path.Combine(desktop, "File.txt");

            do 
            {

                Console.WriteLine("Deseja comprimir ou descomprimir o ficheiro? (1 comprimir/ 2 descomprimir)");
                
                opcao = Console.ReadLine();

                if(opcao == "1")
                {
                    g = true;
                    Comprime(filePath);

                } else if(opcao == "2")
                {
                    g = true;
                    Descomprime(filePath, filePath2);

                } else
                {
                    Console.WriteLine("Escolha invalida.");
                }

            }while(!g);
        }

        static void Comprime(string filePath)
        {
            string line;

            try
            {
                using(FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    using(GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal))
                    {

                        using(StreamWriter sw = new StreamWriter(gzs))
                        {
                            while ((line = Console.ReadLine()).Length > 0)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    
                    } 
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ocorreu um erro de E/S na criação ou escrita no arquivo.");
            }
            catch (UnauthorizedAcessException)
            {
                Console.WriteLine("Sem permissão para aceder ao arquivo.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Não tem permissão para aceder ao arquivo devido a restrições de segurança.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("O modo de abertura do arquivo não é suportado.");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Uma operação foi realizada após o StreamWriter ter sido fechado.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("O caminho do arquivo é inválido ou o nome do arquivo contém caracteres inválidos.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("O diretório especificado no caminho não foi encontrado.");
            }
        }

        static void Descomprime(string filePath, string filePath2)
        {
            string line;

            try
            {
                using(FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using(GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress))
                    {
                        using(StreamReader sr = new StreamReader(gzs))
                        
                        using(StreamWriter sw = new StreamWriter(filePath2))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {

                            Console.WriteLine(line);
                            sw.WriteLine(line);
                                        
                            }
                        }
                        
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Ocorreu um erro de E/S na leitura ou gravação no arquivo.");
            }
            catch (UnauthorizedAcessException)
            {
                Console.WriteLine("Sem permissão para aceder ao arquivo ou gravar no diretório de destino.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Não tem permissão para aceder ao arquivo devido a restrições de segurança.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("O arquivo não foi encontrado no caminho especificado.");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Uma operação foi realizada após o StreamWriter ou o StreamReader ter sido fechado.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("O caminho do arquivo é inválido ou o nome do arquivo contém caracteres inválidos.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("O diretório especificado no caminho não foi encontrado.");
            }
            
                       

        }
    }
}