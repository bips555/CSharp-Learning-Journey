namespace ParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("price is {0},pi is {1},at is {2}",200,3.14,'@');
            /* string[] sentence = new string[] { "this", "is", "a new string", "and", "i dont know", "when it is going to end...." };
             ParamsMethod(sentence);*/
            /*PrintNumbers(1, 2, 3);
            PrintNumbers(1, 2, 3, 4, 5);
            PrintNumbers();*/
            /* int num = 3;
             string name = "biplove";
             char at = '@';
             Objects(num, name, at);
             Objects(1, "sam", '4');*/
            int min = FindMin(1, 2, -3, -2, -6, 4, 0);
            Console.WriteLine("minimum value is {0}",min);

            Console.ReadKey();
        }

        public static int FindMin(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int i in numbers)
            {
                if (i < min)
                    min = i;
            }
                return min;
            }
        public static void Objects( params object[] obj)
        {
            foreach(object o in obj)
            {
                Console.WriteLine(o);
            }
        }
        public static void PrintNumbers(params int[] numbers)
        {
            foreach(int i in numbers)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");

            }
        }
    }
}
