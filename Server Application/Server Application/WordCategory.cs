using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Application
{
    internal static class WordCategory
    {
        static string[] fruits = File.ReadAllLines(@"C:\Users\Lenovo\Desktop\Guess-the-Name-WinGame\Server Application\Server Application\WordCategoryFiles\Food.txt");
        static string[] sports = File.ReadAllLines(@"C:\Users\Lenovo\Desktop\Guess-the-Name-WinGame\Server Application\Server Application\WordCategoryFiles\Sports.txt");
        static string[] languages = File.ReadAllLines(@"C:\Users\Lenovo\Desktop\Guess-the-Name-WinGame\Server Application\Server Application\WordCategoryFiles\Languages.txt");

        public static string GetCategory(string category)
        {
            int randomIndex = new Random().Next(0, 5);

            switch (category)
            {
                case "Fruits": return fruits[randomIndex];
                case "Sports": return sports[randomIndex];
                case "Languages": return languages[randomIndex];
                default: return string.Empty;
            }
        }
    }
}
