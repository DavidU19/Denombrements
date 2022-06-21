using System;

namespace Denombrements
{
    class Program
    {
        static int t = 0, n = 0;
        static bool correct = false; 
        static void saisie()
        {
            while (correct != true)
            {
                try
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    t = int.Parse(Console.ReadLine()); 
                    Console.Write("nombre d'éléments dans le sous ensemble = "); 
                    n = int.Parse(Console.ReadLine());
                    correct = true;
                }

                catch
                {
                    Console.WriteLine("Erreur, veuillez saisir une valeur numérique");
                }
            }
            correct = false;
        }
        static void Main(string[] args)
        {
            int choix = 1;
            long r = 0, r1 = 1, r2 = 1;
            while (choix != 0)
            {
                while (correct != true)
                {
                    try
                    {
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true; 
                    }

                    catch
                    {
                        Console.WriteLine("Erreur, Entrez un nombre numérique"); 
                    }
                }
                correct = false; 

                switch (choix)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        while (correct != true)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = "); 
                                n = int.Parse(Console.ReadLine()); 
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur, entrez une valeur numérique");
                            }
                        }
                        // calcul de r
                        r = 1;
                        for (int k = 1; k <= n; k++)
                            r *= k;
                        Console.WriteLine(n + "! = " + r);

                        break;
                    case 2:
                        saisie();

                        // calcul de r
                        r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);

                        break;
                    case 3:
                        saisie();

                        // calcul de r1
                        r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;

                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break; 
                }
            }
            Console.ReadLine();
        }
    }
}
