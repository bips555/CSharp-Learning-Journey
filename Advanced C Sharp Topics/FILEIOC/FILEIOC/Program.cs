
using System.IO;
namespace FILEIOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reading from a file
            /*string text = System.IO.File.ReadAllText(@"C:\Users\BIPLOV\OneDrive\Desktop\CsharpFile.txt");

            Console.WriteLine("Text file contains following text :{0}",text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\BIPLOV\OneDrive\Desktop\CsharpFile.txt");
            foreach(string line in lines)
            {
                Console.WriteLine("\t"+line);
            }*/

            //Writing to a file

            //method 1

            string[] lines = { "first line", "second line", "third line" };

            /*System.IO.File.WriteAllLines(@"C:\Users\BIPLOV\OneDrive\Desktop\CsharpFile.txt", lines);

            string highScore1 = "200";
            string highScore2 = "300";
            string highScore3 = "400";
            string[] highScores = new string[]
            {
                highScore1, highScore2, highScore3
            };
           
                System.IO.File.WriteAllLines(@"C:\Users\BIPLOV\OneDrive\Desktop\CsharpFile2.txt", highScores);*/


            //method 2
            Console.WriteLine("Enter file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter content for the file you entered");
            string content = Console.ReadLine();

        /*    System.IO.File.WriteAllText(@"C:\Users\BIPLOV\OneDrive\Desktop\" + fileName + ".txt", content);*/

            //method 3
            using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(@"C:\Users\BIPLOV\OneDrive\Desktop\" + fileName + ".txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("line"))
                    {
                        streamWriter.WriteLine(line);
                    }


                }
            }
            using (StreamWriter streamWriter1 = new StreamWriter(@"C:\Users\BIPLOV\OneDrive\Desktop\" + fileName + ".txt", true))
            {
                streamWriter1.WriteLine("Additional line");
            }

                Console.ReadKey();
        }
    }
}
