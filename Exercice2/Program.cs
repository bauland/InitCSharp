using System;
using System.Diagnostics;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fonctions récursives
            //
            // Créer un programme pour afficher le résultat de la suite de Fibonacci pour 25.
            //
            // Rappels:
            // - pour afficher dans la fenêtre de la console:
            //      Console.WriteLine(s);
            // - pour afficher dans la fenêtre de débogage:
            //      Debug.WriteLine(s);
            //
            // avec s la chaine de caractere à afficher
            // 

            var resultat = Fibonacci(25);
            Console.WriteLine(resultat);
            Debug.WriteLine(resultat);
            PauseDeFin();
        }

        static int Fibonacci(int n)
        {
            // TODO: A compléter

        }

        private static void PauseDeFin()
        {
            Console.WriteLine("Appuyez sur une touche pour terminer le programme ...");
            Console.ReadKey();
        }
    }
}