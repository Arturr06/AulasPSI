using System;

namespace BCPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Cor aa = new Cor(25, 37, 41);
            Cor bb = new Cor(27, 41, 53);
            Cor cc = new Cor(8, 24, 35);
            Cor dd = new Cor(12, 55, 43);
            Cor zz = new Cor(2, 5, 34);
            
            Bola a = new Bola(2, aa);
            Bola b = new Bola(35, bb);
            Bola c = new Bola(12, cc);
            Bola d = new Bola(6, dd);
            Bola z = new Bola(9, zz);

            Console.WriteLine("A bola A foi atirada. ");
            a.Atirar();
            Console.WriteLine("A bola C foi atirada. ");
            c.Atirar();
            Console.WriteLine("A bola B foi atirada. ");
            b.Atirar();
            Console.WriteLine("A bola C foi atirada. ");
            c.Atirar();
            Console.WriteLine("A bola D foi atirada. ");
            d.Atirar();
            Console.WriteLine("A bola Z foi atirada. ");
            z.Atirar();
            Console.WriteLine("A bola B foi atirada. ");
            b.Atirar();
            Console.WriteLine("");

            Console.WriteLine("A bola A foi rebentada. ");
            a.Pop();
            Console.WriteLine("");
            Console.WriteLine("A bola B foi rebentada. ");
            b.Pop();
            Console.WriteLine("");
            Console.WriteLine("A bola C não foi rebentada. ");
            Console.WriteLine("");
            Console.WriteLine("A bola D foi rebentada. ");
            d.Pop();
            Console.WriteLine("");
            Console.WriteLine("A bola Z não foi rebentada. ");
            Console.WriteLine("");

            Console.WriteLine("A bola A tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {aa.Red}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {aa.Green}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {aa.Blue}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {a.Raio}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola A foi atirada: {a.NVezes}");
            Console.WriteLine("");
            Console.WriteLine("A bola B tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {bb.Red}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {bb.Green}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {bb.Blue}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {b.Raio}");
              Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola B foi atirada: {b.NVezes}");
            Console.WriteLine("");
            Console.WriteLine("A bola C tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {cc.Red}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {cc.Green}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {cc.Blue}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {c.Raio}");
              Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola C foi atirada: {c.NVezes}");
            Console.WriteLine("");
            Console.WriteLine("A bola D tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {dd.Red}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {dd.Green}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {dd.Blue}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {d.Raio}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola D foi atirada: {d.NVezes}");
            Console.WriteLine("");
            Console.WriteLine("A bola Z tem:");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {zz.Red}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {zz.Green}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {zz.Blue}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {z.Raio}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que a bola Z foi atirada: {z.NVezes}");
        }
    }
}
