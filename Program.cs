using System.Diagnostics.Metrics;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedList<string, string> bucketList = new SortedList<string, string>();
            
            bucketList.Add("Michigan", "Detroit");
            bucketList.Add("Florida", "Orlando");
            bucketList.Add("Illinois", "Chocago");
            bucketList.Add("New York", "New York City");
            bucketList.Add("Texas", "Austin");
            
            Console.WriteLine("Big City Bucket List:");
            foreach (KeyValuePair<string, string> bl in bucketList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
            Console.WriteLine("What is your favorite big city?");
            string city = Console.ReadLine();

            Console.WriteLine("What state is it in?");
            string state = Console.ReadLine();

            if (bucketList.ContainsValue(city))
                Console.WriteLine($"{city} is one of the cities in your list");
            else
            {
                if (bucketList.ContainsKey(state))
                {
                    Console.WriteLine($"This list can only contain one city from {state}.");
                    bucketList.Remove(state);
                    bucketList.Add(state, city);
                    Console.WriteLine($"The current city from {state} has been removed and was replaced with {city}");
                }
                else
                {
                    bucketList.Add(state, city);
                    Console.WriteLine($"{city}, {state} was added to your list");
                }
            }
            Console.WriteLine("The updated list of big cities and their states:");
            foreach (KeyValuePair<string, string> bl in bucketList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
        }
    }
}