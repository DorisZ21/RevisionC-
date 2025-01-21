using System;

namespace labo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Dorian", "Michaux", new DateTime(2004, 1, 21));
            Console.WriteLine(player1);
        }
    }
}

