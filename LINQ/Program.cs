namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           var videoGames = new List<string>() { "Doom", "Legend of Kyrandia", "NBA Jam", "Mortal Kombat" };
           
           var sortedGames = videoGames.OrderBy(title => title.Length).ToList();
        
           foreach (var title in  sortedGames)
            {
                Console.WriteLine(title);
            }
        
        
        
        }
    }
}
