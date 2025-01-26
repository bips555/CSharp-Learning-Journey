namespace Linq1stExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            OddNumbers(numbers);
            string[] names = { "Alice", "Claus", "Bob", "Akay" };
            var query = from name in names
                        orderby name descending
                        select name;
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

            var sortedNumbers = from num in numbers
                                where num > 5
                                orderby num descending
                                select num;
            foreach (var num in sortedNumbers)
            { 
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers");
            IEnumerable<int> oddNumbers = from num in numbers where num % 2 != 0 select num;
            foreach (int num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
