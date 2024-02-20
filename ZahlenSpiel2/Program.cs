using System;
 
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Zufällige Zahl zwischen 1 und 100
        int attempts = 0;
 
        Console.WriteLine("Willkommen zum Zahlenratespiel zwischen 1 und 100!");
 
        int guess = 0;
        do
        {
            Console.Write("Gib deine Schätzung ein (zwischen 1 und 100): ");
            string input = Console.ReadLine();
 
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
                continue;
            }
 
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Die Zahl muss zwischen 1 und 100 liegen.");
                continue;
            }
 
            attempts++;
 
            if (guess < secretNumber)
            {
                Console.WriteLine("Zu niedrig! Versuche es erneut.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Zu hoch! Versuche es erneut.");
            }
            else
            {
                Console.WriteLine($"Glückwunsch! Du hast die geheime Zahl {secretNumber} erraten.");
            }
 
        } while (guess != secretNumber);
 
        Console.WriteLine($"Anzahl der Versuche: {attempts}");
        Console.WriteLine("Vielen Dank fürs Spielen!");
    }
}
