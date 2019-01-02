using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Entrez votre âge = ");
            int.TryParse(Console.ReadLine(), out age); // L'utilisateur doit entrer sa valeur.
            bool mineur = (age < 18);
            if (mineur)
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
            else
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
        }
    }
}
