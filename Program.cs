using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero teste = new Hero("Arus", 41, "Cavaleiro");
            System.Console.WriteLine(teste.ToString());
        }
    }
}
