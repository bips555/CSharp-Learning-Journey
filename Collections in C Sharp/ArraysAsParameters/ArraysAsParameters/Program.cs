namespace ArraysAsParameters
{
    internal class Program
    {
        static double average = 0;
        static int sum = 0;
        static void Main(string[] args)
        {
            /*double average = GetAverage(new int[] {1,2,3});*/
            int[] studentGrades = new int[] { 12, 5, 63, 25, 1 };
            /* Console.Write("the average of ");
             for (int i = 0; i < studentGrades.Length; i++)
             {
                 Console.Write(" {0}  ", studentGrades[i]);
             }
             double average = GetAverage(studentGrades);
             Console.WriteLine("is {0}",average);*/


            //Challenge
            /*
                        int[] happiness = new int[5] { 1, 2, 3, 4, 5 };
                        Console.WriteLine("Initially Array is");
                        for (int i = 0; i < happiness.Length; i++)
                        {
                            Console.WriteLine(happiness[i]);

                        }
                        Console.WriteLine("After increment happiness is:");
                        Array newHappiness = IncreaseBy2(happiness);
                        foreach (int i in newHappiness)
                        {
                            Console.WriteLine(i);
                        }

                        static double GetAverage(int[] gradesArray)
                        {
                            int size = gradesArray.Length;
                            double sum = 0;
                            double average = 0;
                            for (int i = 0; i < size; i++)
                            {
                                sum += gradesArray[i];
                            }
                            average = sum / size;
                            return average;
                        }
                        static Array IncreaseBy2(int[] happiness)

                        {
                            int size = happiness.Length;
                            for (int i = 0; i < size; i++)
                            {
                                happiness[i] = happiness[i] + 2;

                            }
                            return happiness;
            */

            int[] happiness = new int[] { 1, 2, 3, 4, 5 };
            Array newHappiness = IncreaseBy2(happiness);
            foreach (int i in newHappiness)
            {
                Console.WriteLine(i);
            }


            }
       public static Array IncreaseBy2(int[] happiness)
        {
            for (int i=0;i<happiness.Length;i++)
                 {
                happiness[i] = happiness[i] + 2;
               
            }
            return happiness;

        }
    }
}