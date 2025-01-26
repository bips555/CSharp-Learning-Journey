using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Linq.Expressions;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] grades = new int[10];
             grades[0] = 12;
             grades[1] = 15;
             grades[2] = 16;
             grades[3] = 14;
             grades[4] = 19;*/

            //Can be assigned like this to

            /*  int[] gradesOfMathStudentsA = { 4, 3, 2, 2, 3, 4 };
              int[] gradesOfMathStudentsB = new int[] { 4, 3, 2, 5, 6, 2 };*/


            /* int[] arr = new int[5];
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine("Enter {0} array Element",i);
                 string str = Console.ReadLine();
                 int input;
                 bool success = int.TryParse(str, out input);
                 if(success)
                 {
                     arr[i] = input;
                 }
                 else
                 {
                     Console.WriteLine("Could not parse input of array Element {0}",i);
                 }
             }
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine("Your {0} element is {1} ",i, arr[i]);
             }
 */
            /* int[] input = new int[5] {13,64,24,65,12};
             int counter = 0;*/
            /*

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i;
            
            }
            for(int j = 0; j < input.Length;j++)
            {
                Console.WriteLine("Element{0} is {1}", j, input[j]);
            }*/
            /* foreach (int i in input)
             {
                 Console.WriteLine("Element {0} is {1}",counter,i);
                 counter++;
             }*/
            /* string[] bestFriends = new string[5] { "Ram", "Shyam", "Hari", "Sita", "Geeta" };
             foreach(string i in bestFriends)
             {
                 Console.WriteLine("Hello {0}",i);
             }*/




            /*  85) Challenge
                  Create an application that takes 2 input values.

                  Any input value(1st input)

                  Asks the data type of the input value. (2nd input)

                  It will print to the console the options like below to take input for the 2nd input value:

                  Press 1 for String

                  Press 2 for integer

                  Press 3 for Boolean

                  If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not.Hereby we even want to check, if it is a complete alphabetic entry(so no numbers accepted)

                  If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

                  Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

                  Please make sure to use a switch statement.To check the valid string you can write your custom logic.

 

  
            bool isValid = false;
            string inputDataType = "unknown";
            Console.WriteLine("Enter a value:");
            string value = Console.ReadLine();
            Console.WriteLine(" Select the Data type to validate the input you have entered.");
            Console.WriteLine(" Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine(" Press 3 for Boolean");
            Console.Write("Enter: ");
            string enteredNumAsString = Console.ReadLine();
            int enteredNum;
            bool success = int.TryParse(enteredNumAsString, out enteredNum);
            if (success)
            {
                switch (enteredNum) { 
                
                    case 1:
                        isValid = IsAllAlphabet(value);
                        inputDataType = "String";
                        break;
                    case 2:
                        int retValueInt = 0;
                        isValid = int.TryParse(value, out retValueInt);
                        inputDataType = "Integer";
                        break;
                    case 3:
                        bool retValuebool = false;
                        isValid = bool.TryParse(value, out retValuebool);
                        inputDataType = "Boolean";
                        break;
                    default:
                        inputDataType = "unknown";
                        Console.WriteLine("Could not Know your Data Type of input Value");
                        break;
                }

                Console.WriteLine("You have entered a value: {0}", value);
                if (isValid)
                {

                    Console.Write("It is a Valid : {0}", inputDataType);

                }
                else
                {
                    Console.WriteLine("It is a invalid : {0}", inputDataType);
                }
            }
            else
            {
                Console.WriteLine("Enter only 1,2 and 3.");
            }*/

            //Multi Dimensional Arrays
            // Declaring 2D array


            /* Console.WriteLine("Enter number of rows");
             string inputRows=Console.ReadLine();
             int rows = int.Parse(inputRows);
             Console.WriteLine("Enter number of Columns");
             string inputCols = Console.ReadLine();
             int cols = int.Parse(inputCols);
             int[,] matrix = new int[rows, cols];

             for (int i =0;i<rows;i++)
             {
                 for(int j = 0;j<cols;j++)
                 {
                     Console.WriteLine($"Enter element [{i + 1},{j + 1}] of Matrix:");
                     string value = Console.ReadLine();
                     int valueInt = int.Parse(value);
                     matrix[i,j] = valueInt;
                 }
             }
             for (int i = 0; i < rows; i++)
             {
                 for (int j =0; j <cols; j++)
                 {
                     Console.Write("{0}  ", matrix[i,j]);
                 }
                 Console.WriteLine("\n");
             }
 */
            /* string[,,] array3D = new string[,,]
             {
                {
                    {
                        "000","001"
                    },
                    {
                        "010","011"
                    },
                    {
                        "020","021"
                    }
                },
                {
                    {
                        "100","101"
                    },
                    {
                        "110","111"
                    },
                    {
                        "120","121"
                    }
                }
             };*/

            /* Console.WriteLine("The value at depth 1 row 2 and column 0 is {0}", array3D[1,2,0]);*/
            /*string[,] array2Dstring = new string[3, 2]
            {
                {
                    "one", "two"
                },
                {
                    "three", "four"
                },
                {
                    "five", "six"
                }
            };*/
            /*  Console.WriteLine(array2Dstring.Length);
              Console.WriteLine(array2Dstring.Rank);*/

            string[,] array2D =
            {
                {
                    "1",
                    "2",
                    "3"
                },
                {
                    "4",
                    "5",
                    "6",

                },
                {
                    "7",
                    "8",
                    "9"
                }
            };
            /* for (int i = 0;i<array2D.GetLength(0); i++)
             {
                 for (int j = 0; j < array2D.GetLength(1); j++)
                 {
                     if ( i == j )
                     {
                         Console.Write("{0}  ", array2D[i, j]);
                     }
                     else
                     {
                         Console.Write(" ");
                     }
                 }
                 Console.WriteLine();
             }*/
            for (int i = 0,  j = 2; i<array2D.GetLength(0);i++, j--)
            {
                Console.WriteLine(array2D[i,j]);
            }
            Console.ReadKey();
        }
        public static bool IsAllAlphabet(string value)
        {
            foreach(char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}