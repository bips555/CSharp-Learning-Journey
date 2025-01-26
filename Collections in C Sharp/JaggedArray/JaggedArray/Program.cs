namespace JaggedArray
{
    public class Program
    {
       public static void Main(string[] args)
        {
            /* int[][] jaggedArray = new int[3][];*/

            /*jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];*/

            /* jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
             jaggedArray[1] = new int[] { 2, 3, 1 };
             jaggedArray[2] = new int[] { 2, 5 };
 */
            /*int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                 new int[] { 2, 3, 1 },
                  new int[] { 21, 5 }
        };
        */
            /*for(int i = 0; i < jaggedArray2.Length; i++)
            {
               for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }

                Console.WriteLine();
            }*/
            string[][] friendJaggedArrays = new string[][]
            {
                new string []{"Ram","shyam"},
                new string [] {"hari","sita"},
                new string []{"sam","bips"}
            };
            Console.WriteLine("Hi {0} I would like you to introduce {1} to you", friendJaggedArrays[1][0], friendJaggedArrays[0][0]);
            Console.WriteLine(friendJaggedArrays[0][0]);
            
            Console.ReadKey();
        }
    }
}
