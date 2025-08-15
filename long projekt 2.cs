using System;// Import the System names
namespace Grundlæggende;

// Main program class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Loop until the user provides a valid response ("ja" or "nej")
        while (true)
        {
            Console.WriteLine("start? ja/nej");// Prompt user to start or exit
            string input = Console.ReadLine()?.Trim().ToLower();// Read and normalize input

            if (input == "ja")
            {
                Console.WriteLine("Du har valgt at starte programmet.");// Confirm start
                Console.Clear();// Clear the console for a clean menu display
                PrintMenu();// Display the menu options

                Console.Write("Vælg et nummer fra menuen: ");
                string choice = Console.ReadLine()?.Trim();


                // Handle the user's choice from the menu
                switch (choice)
                {   
                    case "1":
                        Console.WriteLine("Du har valgt Variabler.");
                        break;
                        
                        Console.writeline("vælg task: 1, 2, 3, 4, eller 5")

                        if (input == 1)
                        {
                            Console.writeling("du har valgt task 1")
                        }

                    case "2":
                        Console.WriteLine("Du har valgt Strings.");
                        break;
                    case "3":
                        Console.WriteLine("Du har valgt Aritmetiske udtryk.");
                        break;
                    case "4":
                        Console.WriteLine("Du har valgt Variabler i udtryk.");
                        break;
                    case "5":
                        Console.WriteLine("Du har valgt Boolske variable.");
                        break;
                    case "6":
                        Console.WriteLine("Du har valgt If-else statements.");
                        break;
                    case"7":
                        Console.WriteLine("Du har valgt Switch Case.");
                        break;
                    case "8":
                        Console.WriteLine("Du har valgt Loops.");
                        break;
                    case "9":
                        Console.WriteLine("Du har valgt Udvidet kontrolstrukturer.");
                        break;
                    case "10":
                        Console.WriteLine("Du har valgt Metoder og instanser.");
                        break;
                    case "11":
                        Console.WriteLine("Du har valgt Returtyper og parametre.");
                        break;
                    case "12":
                        Console.WriteLine("Du har valgt Nedarvning.");
                        break;
                    case "13":
                        Console.WriteLine("Du har valgt Arrays.");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");// Handle invalid choice
                        break;
               
                }


                // You can add menu handling logic here
            }
            else if (input == "nej")
            {
                Console.WriteLine("Du har valgt at afslutte programmet.");// Confirm exit
                return;// Exit the application
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Prøv igen.");// Handle invalid input
            }
        }
    }

    // Prints the menu options to the console
    static void PrintMenu()
    {
        Console.WriteLine("1. Variabler");
        Console.WriteLine("2. Strings");
        Console.WriteLine("3. Aritmetiske udtryk");
        Console.WriteLine("4. Variabler i udtryk");
        Console.WriteLine("5. Boolske variable");
        Console.WriteLine("6. If-else statements");
        Console.WriteLine("7. Switch Case");
        Console.WriteLine("8. Loops");
        Console.WriteLine("9. Udvidet kontrolstrukturer");
        Console.WriteLine("10. Metoder og instanser");
        Console.WriteLine("11. Returtyper og parametre");
        Console.WriteLine("12. Nedarvning");
        Console.WriteLine("13. Arrays");
    }
}