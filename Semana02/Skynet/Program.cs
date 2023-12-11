using System;

namespace Skynet
{
    class Program
    {
        static void Main(string[] args)
        {
            string pergunta = Console.ReadLine();
            string resposta1 = "Benfica";
            string resposta2 = "Lisboa";
            string resposta3 = "Russia";
            

            /*if(pergunta == "Qual o melhor clube do mundo?"){
                Console.WriteLine(resposta1);
            }else if(pergunta == "Qual é a capital de Portugal?"){
                Console.WriteLine(resposta2);
            }else if(pergunta == "Qual é o maior pais do mundo?"){
                Console.WriteLine(resposta3);
            }else {
                Console.WriteLine("Não tenho resposta para isso.");
            }*/

            /*switch (pergunta)
            {
                case "Qual o melhor clube do mundo?" : 
                    Console.WriteLine(resposta1);
                    break;
                case "Qual é a capital de Portugal?" :
                    Console.WriteLine(resposta2);
                    break;
                case "Qual é o maior pais do mundo?" :
                    Console.WriteLine(resposta3);
                    break;        
                default:
                    Console.WriteLine("Não tenho resposta para isso.");
                    break;
            }*/

            do 
            {
                if(pergunta == "EXIT"){
                    
                }

                switch (pergunta)
                {
                    case "Qual o melhor clube do mundo?" : 
                        Console.WriteLine(resposta1);
                        break;
                    case "Qual é a capital de Portugal?" :
                        Console.WriteLine(resposta2);
                        break;
                    case "Qual é o maior pais do mundo?" :
                        Console.WriteLine(resposta3);
                        break;        
                    default:
                        Console.WriteLine("Não tenho resposta para isso.");
                        break;
                }
            } while (pergunta != "EXIT");    
            
            

        }
    }
}
