using System.Runtime.InteropServices;

namespace C__god_morgen;

class Program
{
    static void Main()
    {

        /*
            PSEUDOCODE:
            1. Get the current hour.
            2. Create a dictionary with greetings.
            3. Check the time range:
               - If morning (5-12), use "Good morning!"
               - If afternoon (12-17), use "Good afternoon!"
               - If evening (17-21), use "Good evening!"
               - Otherwise, use "Good night!"
            4. Print the selected greeting.
            */


        // Step 1: Get the current hour
        int hour = DateTime.Now.Hour;

        // Step 2: Define a dictionary with greetings
        Dictionary<string, string> greetings = new Dictionary<string, string>()
        {
            { "morning", "Good morning!" },
            { "afternoon", "Good afternoon!" },
            { "evening", "Good evening!" },
            { "night", "Good night!" }
        };

        string greeting;

        // Step 3: Determine the greeting based on the time
        if (hour >= 5 && hour < 12) // morning starts at 5 AM
        {
            greeting = greetings["morning"];
        }
        else if (hour >= 12 && hour < 17) // afternoon ends at 4:59 PM
        {
            greeting = greetings["afternoon"];
        }
        else if (hour >= 17 && hour < 21) // evening starts at 5 PM
        {
            greeting = greetings["evening"];
        }
        else
        {
            greeting = greetings["night"]; // night starts at 9 PM
        }

        // Step 4: Display the greeting
        Console.WriteLine(greeting);
    }
}
