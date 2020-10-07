using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good AfterNoon!");
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud", "marcus" };
            Random rnd = new Random();

            Console.WriteLine($"NB! {superHeroes[rnd.Next(0, superHeroes.Length)]} will fight {superVillains[rnd.Next(0, superHeroes.Length)]} with a {weapon[rnd.Next(0, weapon.Length)]}.");




                   

            
        }
    }
}
