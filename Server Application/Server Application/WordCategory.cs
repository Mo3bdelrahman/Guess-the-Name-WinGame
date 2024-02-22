namespace Server_Application
{
    internal static class WordCategory
    {
        static string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        static Dictionary<WordCategories, string[]> filePaths = new Dictionary<WordCategories, string[]>() 
        {
            { WordCategories.Food, File.ReadAllLines($@"{currentDirectory}\CategoryFiles\Food.txt")},
            { WordCategories.Sports, File.ReadAllLines($@"{currentDirectory}\CategoryFiles\Sports.txt") },
            { WordCategories.Languages, File.ReadAllLines($@"{currentDirectory}\CategoryFiles\Languages.txt") },
        };

        public static string GetCategory(string category)
        {
            int randomIndex = new Random().Next(0, 5);

            switch (category)
            {
                case "Food": return filePaths[WordCategories.Food][randomIndex];
                case "Sports": return filePaths[WordCategories.Sports][randomIndex];
                case "Languages": return filePaths[WordCategories.Languages][randomIndex];
                default: return string.Empty;
            }
        }
    }
}
