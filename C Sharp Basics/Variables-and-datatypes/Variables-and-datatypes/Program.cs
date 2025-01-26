using System;

namespace Variables_and_datatypes
{
    public class Program
    {
        //static int  age = 20;
        /*int age = 20;
        static decimal x = 100.2m;*/
        //17) Datatypes int float and double
        public static void Main(string[] args)
        {
            /*  Program program = new Program();
              program.age = 10;//changes to 10 now
              Console.WriteLine(program.age);
              Console.WriteLine(x);*/
            /* int num1;//decalring variable
             num1 = 10;*///initializing variable

            //doing it in one go

            /*  int num2 = 20;

              double d1 = 10.1;
              double d2 = 5.2;
              double doubleDiv = d1 / d2;
              Console.WriteLine(doubleDiv);

              float f1 = 10.1f;
              float f2 = 1.3f;
              float floatDiv = f1 / f2;
              Console.WriteLine(floatDiv);


              decimal dec1 = 10.22345m;
              decimal dec2 = 2.330934m;
              decimal decimalDiv = dec1 / dec2;
              Console.WriteLine(decimalDiv);


              int sum = num1 + num2;*/
            //String interpolation
            /*  Console.WriteLine($"Sum of num1 and num2 is {sum}");
              //string formatting
             Console.WriteLine("Sum of {0} and {1} is {2}",num1,num2,sum);
              //string manipulation
              Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + sum);*/

            /*int x = 3;
            double y = 12.2;
             
            double doubleDiv = y / x;
            Console.WriteLine(doubleDiv);*/

            /* int intDiv = y / x;*/   //Will generate error

            /*  int intDiv = (int)y / x;
              Console.WriteLine(intDiv);*/

            // 18) String and some of its methods

            /*string name = "bips";

            string message = "Name is " + name;

            Console.WriteLine(message);

            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.ToUpper());*/

            //21) Console class and its methods

            /*Console.WriteLine("Prints and jumps to next line");
            Console.Write("Prints and jumps into same line");
            Console.WriteLine("next line");*/

            /*Console.WriteLine("Enter a string or number");
            string something = Console.ReadLine();
            Console.WriteLine("Enter string");
            int asciiValueOfInput = Console.Read();
          
            Console.WriteLine(something);
            Console.WriteLine(asciiValueOfInput);*/

            //22) Changing Console Colors
            /* Console.ForegroundColor = ConsoleColor.Red;
             Console.BackgroundColor = ConsoleColor.Green;
             Console.Clear();
             Console.WriteLine("Hey how are u?");*/

            //23)Implicit and Explicit Conversion

            /*  int num = 3;
              long myLongNum = num;
              float myFloatNum = 3.2f;
              double myDoubleNum = myFloatNum;*/

            //Implicit Conversion

            /* int num = 0;
             double myDoubleNum = num;

             Console.WriteLine(num);
             //Explicit Conversion

             float myFloatNum = 3.222f;
             int num1 = (int) myFloatNum;
             Console.WriteLine(num1);
             //Type Casting

             int num2 = 23;
 *//*          string num2AsString  = Convert.ToString(num2);
 *//*          string num2AsString = num2.ToString();
             Console.WriteLine(num2AsString + 1);
             Console.WriteLine("Enter Role number");
             string rollNoAsString = Console.ReadLine();
             int rollNo = Int32.Parse(rollNoAsString);
             Console.WriteLine(rollNo + 1);*/


            //24) Parsing a string to integer

            /*string firstNumString = "12";
            string secondNumString = "23";
            int num1 = Int32.Parse(firstNumString);
            int num2 = Int32.Parse(secondNumString);
            int result = num1 + num2;
            string resultAsString  =firstNumString + secondNumString;
            Console.WriteLine(result);
            Console.WriteLine(resultAsString);*/

            //26) String manipulation

            /*    int age = 23;
                string name = "Biplove Subedi";
                //string concatenation
                Console.WriteLine("Hi, My name is "+name+"and my age is "+age);

                //string formatting - uses index
                Console.WriteLine("My name is {0} and age is {1}",name,age);

                //string interpolation
                Console.WriteLine($"Hi, my name is {name} and my age is {age}");

                //Verbatim strings
                Console.WriteLine(@"/n lorem
                                ipsum  
                                    fos   rres");
                Console.WriteLine(@"C:\User\subed\Pictures\abc.jpeg");
    */
            //27) String and its methods

            /*  int age = 23;
              string name = "bips subedi";
          string info = string.Concat(name,age);
              Console.WriteLine(info);

              string lName = name.Substring(5);
              Console.WriteLine(lName);
              Console.WriteLine(lName.ToUpper());
              Console.WriteLine(name.ToLower());
              int indexOfString = name.IndexOf("sub");
              Console.WriteLine(indexOfString);
              string stringContainingWhitespaces = "   het how are  uuu ";
              Console.WriteLine(stringContainingWhitespaces.Trim());
              string job = Console.ReadLine();
              Console.WriteLine(string.IsNullOrWhiteSpace(job));*/


            //Challenge
            /*string name;
            Console.WriteLine("Please enter your name and press enter");
            name = Console.ReadLine();

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(0,4));*/

            //Challenge
            /*Console.WriteLine("Enter a string here");
           string input = Console.ReadLine();
            Console.WriteLine("Enter the character to search");
            string search = Console.ReadLine();
            Console.WriteLine(input.IndexOf(search));
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lName = Console.ReadLine();
            Console.WriteLine(string.Concat(fName, " ", lName));
           */

            //Challenge

            /* int num = 1234567891;
             sbyte num1 = 123;
             long num2 = 1234567891234567891;
             float num3 = 132454425354235432633456345346785368548.23430f;
             decimal num4 = 1.2m;
             double num5 = 1.0;
             bool isSunday = false;
             char at = '@';
             string firstOne = "I control text";
             int secondOne = 12;
             int firstOneAsNum = Int32.Parse(firstOne);*/

            Console.ReadKey();

        }
    }
}