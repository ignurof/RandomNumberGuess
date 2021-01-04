using System;

namespace HemligaTalet
{
    class HemligaTalet
    {
        static void Main(string[] args)
        {
            //Skapar en ny instans av Random class och använd Next funktionen med en integer
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101);

            Console.Write("Gissa ett slumpmässigt tal från 1 till 100\n");
            int inputNumber = int.Parse(Console.ReadLine());

            if(inputNumber == slump_tal)
            {
                Console.Write("\n\nDin gissning var rätt, grattis!\n");
                Environment.Exit(0); //Avsluta programmet om användaren gissar rätt direkt, för vad är oddsen liksom
            }
            else
            {
                Console.Write("\nDin gissning: " + inputNumber + " var inte rätt...");
            }

            while(inputNumber != slump_tal)
            {
                Console.Write("\nGissa igen och se om du får rätt svar denna gången!\n");
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < slump_tal)
                {
                    Console.Write("\n\nDin gissning var mindre än talet!\n");
                }
                else if (inputNumber > slump_tal)
                {
                    Console.Write("\n\nDin gissning var större än talet!\n");
                }
                else if (inputNumber == slump_tal)
                {
                    Console.Write("\n\nDin gissning var rätt, grattis!\n");
                    ContinueCheck();
                }
            }
        }

        static void ContinueCheck()
        {
            string appEntryCheck;
            bool keepPlayingCheck = true;

            Console.Write("\nVill du fortsätta? Skriv in 'Ja' eller 'Nej'\n\n");

            // Kolla om användaren vill fortsätta köra program loopen
            while (keepPlayingCheck)
            {
                appEntryCheck = Console.ReadLine();

                if (appEntryCheck == "Ja" || appEntryCheck == "J" || appEntryCheck == "ja" || appEntryCheck == "j")
                {
                    keepPlayingCheck = false;
                }
                else if (appEntryCheck == "Nej" || appEntryCheck == "N" || appEntryCheck == "nej" || appEntryCheck == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Du måste göra ett val mellan 'Ja' eller 'Nej'");
                }
            }
        }
    }
}
