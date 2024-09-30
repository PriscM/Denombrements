using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration et saisie du choix
            string c = "4";
            while (c !="0" || c!="1" || c != "2" || c != "3")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = Console.ReadLine();
              
                switch (c)
                {
                    case "0":
                        Environment.Exit(0); 
                        break;

                    case "1":
                        Console.Write("nombre total d'éléments à gérer = ");
                        int n = int.Parse(Console.ReadLine());
                        long r = 1;
                        for (int k = 1; k <= n; k++)
                        {
                            r *= k;
                        }
                        Console.WriteLine(n + "! = " + r);
                        break;
                    case "2":
                        Console.Write("nombre total d'éléments à gérer = ");
                        int t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        n = int.Parse(Console.ReadLine());
                        r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r *= k;
                        }                       
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        break;
                    case "3":
                        //calcul combinaison
                        Console.Write("nombre total d'éléments à gérer = ");
                        t = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        n = int.Parse(Console.ReadLine());
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r1 *= k;
                        }
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                        {
                            r2 *= k;
                        }
                        // calcul de r3               
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;
                    default:
                        Console.WriteLine("Erreur de saisie, veuillez recommencer!");
                        break;
                } 
                Console.ReadLine();
            }
        }
            
    }
}

