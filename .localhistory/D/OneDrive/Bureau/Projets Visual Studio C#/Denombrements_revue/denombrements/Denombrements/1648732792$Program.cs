/**
 * titre : calculs de dénombrements
 * description : permet 3 types de calculs (permutation, arrangement, combinaison)
 * auteur : Emds / Florian Martin
 * date création : 15/06/2020
 * date dernière modification : 31/03/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Menu permettant de faire, plusieurs fois, 3 calculs : permutation, arrangement, combinaison
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();

                if (choix == "0") { Environment.Exit(0); }

                try
                {
                    if (choix == "1")
                    {
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        // saisir le nombre
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r
                        long r = 1;
                        for (int k = 1; k <= n; k++)
                            r *= k;
                        Console.WriteLine(n + "! = " + r);
                    }
                    else
                    {
                        if (choix == "2")
                        {
                            // le nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            // saisir le nombre
                            int t = int.Parse(Console.ReadLine());
                            // le sous ensemble
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            // saisir le nombre
                            int n = int.Parse(Console.ReadLine()); 
                            // calcul de r
                            long r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        }
                        else
                        {
                            // le nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            // saisir le nombre
                            int t = int.Parse(Console.ReadLine());
                            // le sous ensemble
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            // saisir le nombre
                            int n = int.Parse(Console.ReadLine()); 
                            // calcul de r1
                            long r1 = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r1 *= k;
                            // calcul de r2
                            long r2 = 1;
                            for (int k = 1; k <= n; k++)
                                r2 *= k;
                            // calcul de r3
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Calcul impossible: valeur trop grande.");
                }
            }
            Console.ReadLine();
        }
    }
}
