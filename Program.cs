using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 42, "Cavaleiro");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            Wizard jenica = new Wizard("Jenica", 42, "Mago");
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Mago Negro");
            
            System.Console.WriteLine(arus.ToString());
            System.Console.WriteLine(arus.Attack(8));
            System.Console.WriteLine();
            System.Console.WriteLine(wedge.ToString());
            System.Console.WriteLine();
            System.Console.WriteLine(jenica.ToString());
            System.Console.WriteLine();
            System.Console.WriteLine(topapa.ToString());
        }
    }
}
