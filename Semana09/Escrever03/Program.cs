using System;
using System.IO;

namespace Escrever03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, file;
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = desktop;
            StreamReader sr;
            int ll = 0, lc = 0, w = 0;

            Console.WriteLine("Que ficheiro deseja abrir?");
            

            try
            {
                file = Console.ReadLine();

                filePath = Path.Combine(desktop, file);
                
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Ficheiro não encontrado.");
            }
            catch(IOException a)
            {
                Console.WriteLine($"Ocorreu um erro de E/S: {a.Message}");
            }
            finally
            {
                  sr = new StreamReader(filePath);  
                    
                do
                {
                    s = sr.ReadLine();

                    ll++;
                
                    //Console.WriteLine(s);
                }while(s != null);

                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                do
                {
                    w = sr.Read();

                    lc++;

                    //Console.WriteLine(w);
                }while(w != -1);
            }
            
            Console.WriteLine("Número de linhas: ");
            Console.WriteLine(ll);
            Console.WriteLine("");

            Console.WriteLine("Número de carateres: ");
            Console.WriteLine(lc); 

            sr.Close();
        }
    }
}
