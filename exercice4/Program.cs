using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            Console.WriteLine("Entrez votre identifiant = ");
            login = Console.ReadLine();
            Console.WriteLine("Entrez votre mot de passe =");
            password = Console.ReadLine();
            if (login == "Johan" && password == "test") // Si le login et le password est uniquement "Johan" et "test", alors je peux acceder à mon compte.
                Console.WriteLine("Bienvenue à la Manu le Havre.");
            else
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
                    // Login ou password faux donc aucun accés.  


        }
    }
}
