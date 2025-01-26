using System.ComponentModel;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //video no :- 38

            /* int sum =  Add(2, 3);
                Console.WriteLine($"Sum is {sum}");*/

            //video no:-39

            /*name();
            NameAsParamater("bips subedi");*/

            //video no:-40

            /* int result = Add(Add(1,2), Add(3,4));
               Console.WriteLine(result);*/
            /*double resultRight =   divisionDoneRight(14, 13);
              Console.WriteLine(resultRight);
              double wrongResult = divisionDoneWrong(14, 13);
              Console.WriteLine(wrongResult);*/

            //Video no :-42

            /*Calculate();*/


            //Video no:- 43 and 44
            /*Console.WriteLine("Enter something");
            string numAsString=Console.ReadLine();
            
            try
            {
              int num = int.Parse(numAsString);

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("rest of the code..");
            }*/

            //Video no:-45

            //unary operators

            int num1 = 3;
            int num2;
            num2 = -num1;
            Console.WriteLine(num2);

            bool isSunny = true;
            Console.WriteLine("is it Sunny = {0}",!isSunny);


            Console.ReadKey();
            
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public static void name()
        {
            Console.WriteLine("hey, i am bips");
        }
        public static void NameAsParamater(string name)
        {
            Console.WriteLine($"Hello, i am {name}");
        }

        public static double divisionDoneWrong(int num1,int num2)
        {
            return num1 / num2;
        }
        public static double divisionDoneRight(double num1, double num2)
        {
            return num1 / num2;
        }
        public static void Calculate()
        {
            Console.WriteLine("Enter 1st num");
            string num1AsString  = Console.ReadLine();
            Console.WriteLine("Enter 2nd num");
            string num2AsString = Console.ReadLine();
            int num1 = int.Parse(num1AsString);
            int num2 = int.Parse(num2AsString);
            int sum = num1+num2;
            Console.WriteLine($"sum is {sum}");

        }
    }
}
