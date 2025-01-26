namespace IenumerableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bookTitles = new string[] { "1982", "To kill a mockingBird", "Great Gatsby" };
            List<string> books = new List<string>() { "1982", "To kill a mockingBird", "Great Gatsby" };
            Console.WriteLine("bookTitles");
            Library library = new Library();
            library.PrintBookTitles(books);
            Console.WriteLine("Books");
            library.PrintBookTitles(bookTitles);
        }
    }
    public class Library
    {
        public void PrintBookTitles(IEnumerable<string> booktitles)
        {
            foreach (string title in booktitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
