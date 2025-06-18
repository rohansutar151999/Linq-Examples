namespace Linq_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 12, 15, 7, 3, 20 };

            //Linq method system
            //var result = from n in numbers
            //             where n > 10
            //             select n;

            var result = numbers.Where(n => n > 10);

            foreach (var n in result) 
            {
                Console.WriteLine(n);
                Console.WriteLine("Hello develop branch");
            }
        }
    }
}
