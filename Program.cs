namespace Schere_Stein_Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programmieren Sie ein Schere, Stein, Papier Spiel.
            //Der User soll eines der Handzeichen wählen können.
            //Der Computer wählt per Zufall ein eigenes Zeichen. (recherchieren Sie hierzu Random für C#)
            //Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen, verloren oder ein Unentschieden hat.
            //Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.


            Console.WriteLine("Willkommen zu Schere, Stein, Papier!");
            
            while (true) 
            {
                Console.WriteLine("Bitte wähle: Schere, Stein oder Papier.");
                string spielerWaehlt = Console.ReadLine().ToLower();
                
                if (spielerWaehlt != "schere" && spielerWaehlt != "stein" && spielerWaehlt != "papier")
                {
                    Console.WriteLine("Eingabe ungültig! Bitte gib 'Schere', 'Stein' oder 'Papier' ein.");
                    return;
                }

                Random rand = new Random();
                string[] options = { "schere", "stein", "papier" };
                string computerWaehlt = options[rand.Next(options.Length)];

                Console.WriteLine($"Computer wählt: {computerWaehlt}");

                if (spielerWaehlt == computerWaehlt)
                {
                    Console.WriteLine("Unentschieden!");
                }
                else if ((spielerWaehlt == "schere" && computerWaehlt == "papier") ||
                         (spielerWaehlt == "stein" && computerWaehlt == "schere") ||
                         (spielerWaehlt == "papier" && computerWaehlt == "stein"))
                {
                    Console.WriteLine("Du hast gewonnen!");
                }
                else
                {
                    Console.WriteLine("Der Computer hat gewonnen!");
                }

                Console.WriteLine("\nMöchtest du noch eine Runde spielen? (y/n)");
                string neueRunde = Console.ReadLine().ToLower();

                if (neueRunde != "y")
                {
                    Console.WriteLine("Vielen Dank für's spielen!");
                    break;
                }
                 
                
            }
        }
    }
}