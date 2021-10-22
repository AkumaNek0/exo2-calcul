using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;

            Random rand = new Random();
            int minrandom = 1;
            int maxrandom = 3;

            int calcmin = 1;
            int calcmax = 11;

            int Question = 0;

            //ajouter fonction pour pouvoir rappeler quand catch erreur

            while (Question < 5)
            {
                Question = Question + 1;

                Console.WriteLine("Il reste " + Question + "/5 questions.");
                int Coinflip = rand.Next(minrandom, maxrandom);

                Random randcalc = new Random();
                int Calc = randcalc.Next(calcmin, calcmax);
                int Calc2 = randcalc.Next(calcmin, calcmax);

                if (Coinflip == 1)
                {
                    Console.WriteLine(Calc + "+" + Calc2 + "=");
                    int resultat = (Calc + Calc2);
                    try
                    {
                        guess = int.Parse(Console.ReadLine());

                        if (guess == resultat)
                        {
                            Console.WriteLine("Bonne réponse.");
                        }
                        else
                        {
                            Console.WriteLine("Faux !");
                        }
                    }
                    catch
                    { 
                        Console.WriteLine("Erreur, entre une réponse correcte.");

                    }

                    


                }
                else
                {
                    Console.WriteLine(Calc + "x" + Calc2 + "=");
                    int resultat = (Calc * Calc2);
                    try
                    {
                        guess = int.Parse(Console.ReadLine());
                        if (guess == resultat)
                        {
                            Console.WriteLine("Bonne réponse.");
                        }
                        else
                        {
                            Console.WriteLine("Faux !");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur, entre une réponse correcte.");

                    }
                }
                

            }



            Console.WriteLine("Tu as fini.");





        }
    }
}
