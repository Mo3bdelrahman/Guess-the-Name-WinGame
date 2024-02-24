using System.Collections.Generic;

namespace Server_Application
{
    internal static class WordCategory
    {
        static string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        static Dictionary<string, string> filePaths = new Dictionary<string, string>() 
        {
            {"Food", $@"{currentDirectory}\CategoryFiles\Food.txt"},
            {"Sports",$@"{currentDirectory}\CategoryFiles\Sports.txt" },
            {"Languages", $@"{currentDirectory}\CategoryFiles\Languages.txt" },
        };

        public static string GetRandomWord(string category)
        {    
            string[] words = File.ReadAllLines(filePaths[category]);
            int randomIndex = new Random().Next(0, 5);
           return words[randomIndex];
        }

        public static bool AddCategory(string catName,string path)
        {
            try
            {
                filePaths.Add(catName, path);
                return true;
            }
            catch { return false; }
            
        }
        public static bool ReomveCategory(string catName)
        {
            try
            {
                filePaths.Remove(catName);
                return true;
            }
            catch { return false; }

        }

        public static string[] GetAllCategories()
        {
           return filePaths.Keys.ToArray();
        }
    }
}
