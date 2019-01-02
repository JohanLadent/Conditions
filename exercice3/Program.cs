using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Entrez votre âge = ");
            int.TryParse(Console.ReadLine(), out age);
            String sexe;
            Console.WriteLine("Entrez votre sexe = ");
            sexe = Console.ReadLine();           
            bool mineur = (age < 18);
            bool homme = true;
            if (mineur)
                Console.WriteLine("Vous êtes un(e) " + sexe + " et vous êtes mineur.");
            else
                Console.WriteLine("Vous êtes un(e) " + sexe + " et vous êtes majeur.");

            


        }
    }
}
