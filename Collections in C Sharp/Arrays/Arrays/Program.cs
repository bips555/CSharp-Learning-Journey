using System.ComponentModel.DataAnnotations;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] grades = new int[5];
            grades[0] = 1;
            grades[1] = 2;
            grades[2] = 3;
            grades[3] = 4;
            grades[4] = 5;

            Console.WriteLine($"Grades at 0 is {grades[0]}");
            Console.WriteLine("Enter an integer");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine($"Grades at 0 is {grades[0]}");

            //another way of initializing an array

            int[] gradesofMathStudentsA = new int[] {1,2,3,4,5,6 };

            //Another way of initializing an Array
            int[] gradesofMathStudentsB = { 1, 2, 3, 4, 5 };


            Console.WriteLine("Length of Array is {0}",gradesofMathStudentsA.Length);*/


            //foreach loop

            /*int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i+10;
            }
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Value of nums at {0} is {1}", j, nums[j]);
            }
            int counter = 0;
            foreach( int k in nums)
            {
                Console.WriteLine("Value at {0} is {1}",counter,k);
                counter++;
            }

            string[] friends = { "bipana", "sapana", "kalpana" };
            foreach (string name in friends)
            {
                Console.WriteLine($"HI , my dear friend {name}");
            }*/

            //Challenge

            /*bool valid = false;
            
            Console.WriteLine("Enter a value:");
            string input = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered.");

            Console.WriteLine("Press 1 for string");
            Console.WriteLine("Press 2 for integer");
            Console.WriteLine("Press 3 for boolean");
            Console.WriteLine("Enter:");
            string inputType = string.Empty; ;
            

            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                   
                   valid = IsALlAlphabetic(input);
                    inputType = "string";
                    break;
                case 2:
                    int retType = 0;
                    valid = int.TryParse(input,out retType);
                    inputType = "integer";
                    break;
                case 3:
                    bool retTypebool = false;
                    valid = bool.TryParse(input, out retTypebool);
                    inputType = "boolean";

                    break;
                default:
                    Console.WriteLine("Please press correct values.");
                    break;
            }
            Console.WriteLine("You have entered a value: {0}", input);
            if (valid)
            {
             
                Console.WriteLine("It is a valid {0}",inputType);
            }
            else
            {
                Console.WriteLine("It is an invalid :{0}",inputType);
            }*/


            //Multi dimensional Arrays

            //2D array

            /*int[,] array = new int[,]
            {
                {20,21,22 },
                {10,11,12 },
                {20,21,22}
        };
            Console.WriteLine("Central value is {0}", array[1,1]);

            for(int i = 0; i<array.GetLength(0); i++)
            {
                for(int j= 0; j<array.GetLength(1);j++)
                {
                    Console.Write(" " +array[i,j]);
                }
                Console.WriteLine();
            }

            //3D array

            string[,,] array3D = new string[,,]
            {
                {
                    {
                       "000","001","002"
                    },

                    {
                         "010","011","012"
                    }

                },
                {

                    {
                         "100","101","102"
                    },
                    {
                         "110","111","112"
                    }
                },
                {

                    {
                         "200","201","202"
                    },
                    {
                         "210","211","212"
                    }


                }
               
            };*/
            /* Console.WriteLine(array3D.Rank);*/

            /*  int[,] array2D = new int[,]
              {
                  {1,2,3},
                  {4,5,6},
                  {7,8,9}
              };

              for (int i = 0; i < array2D.GetLength(0); i++)
              {
                  for (int j = 0; j < array2D.GetLength(1); j++)
                  {
                      if (array2D[i, j] == array2D[j,i]  )
                      {
                          Console.Write(array2D[i, j] + " ");
                      }


                  }
                  Console.WriteLine();
              }
              for (int i = 0, j = 2; i < array2D.GetLength(0); i++, j--)
              {
                  Console.WriteLine(array2D[i,j]);
              }*/


            //JaggedArray

            //jagged array is array within an array

            /*int[][] jaggedArray = new int[][]
            {
                new int [] {1,2,3,4,5},
                 new int [] {1,2,3},
                  new int [] {1,2}

            };*/
            //   Console.WriteLine(jaggedArray.Length);

            /* for(int i = 0; i<jaggedArray.Length; i++)
             {
                 for(int j= 0;j<jaggedArray[i].Length;j++)
                 {
                     Console.Write(jaggedArray[i][j] + " ");
                 }
                 Console.WriteLine();
             }*/

            //CHallenge

            /* string [][] jaggedFriendsArray = new string[][]
             {
                new string []{"Hary","Jane"},
                new string []{"Biplob","Bimala"},
                new string []{"shiva","pushpa"}
             };

             for (int i = 1; i < jaggedFriendsArray.Length; i++) {
                 for (int j = 0; j < jaggedFriendsArray[i].Length; j++)
                 {
                     Console.WriteLine("Hi {0} I am Harry", jaggedFriendsArray[i][j]);
                     Console.WriteLine("Hi {0} I am Jane", jaggedFriendsArray[i][j]);
                 }
             }*/


            //93) Using arrays as parameters

            /*int[] grades = new int[] { 10, 10, 30};

            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }
            double gradesAverage =  GetAverage(grades);
            Console.WriteLine("Average of grades is {0}",gradesAverage);*/

            /* int[] happiness = { 1, 2, 3, 4, 5 };
             IncreaseBy2(happiness);
             foreach (int i in happiness)
             {
                 Console.WriteLine(i);
             }*/

            //Params keyword

            /* int num = 3;
             double doubleNum = 3.14;
             char character = '@';
             string name = "bips";
             bool isSunday = false;

             objectsPrint(num,doubleNum,character,name,isSunday);



             PrintNumbers(2, 3, 4, 5);*/


            //Using params to get the maximum or minimum value 


    double min = FindMin(2, 3, 4.4, 1.3,-1.3);
            Console.WriteLine(min);


            Console.ReadKey();

           
        }
        static bool IsALlAlphabetic(string value)
        {
            foreach(char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
                
            }
            return true;
        }

        static double GetAverage(int[] grades)
        {
            double average = 0;
            int total = 0;
            foreach (int i in grades)
            {
                total += i;
            }
            average =(double) total / grades.Length;
            return average;
        }
        static Array IncreaseBy2 (int[] happiness)
        {
            for(int i= 0;i<happiness.Length;i++)
            {
                happiness[i] = happiness[i] + 2;
              
            };
            return happiness;
        }
        static void PrintNumbers(params int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void objectsPrint(params object[] objects)
        {
            foreach( object obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
        static double FindMin(params double[] numbers)
        {
            double min = int.MaxValue;
            Console.WriteLine(min);
            foreach(double d in numbers)
            {
                if(d<min)
                {
                    min = d;
                }
            }
            return min;
        }
    }
}
