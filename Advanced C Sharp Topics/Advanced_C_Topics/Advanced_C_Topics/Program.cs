namespace Advanced_C_Topics
{

    //Enums are placed at namespace level
    //Enums are set of constants which cannot be changed afterwards once it's initialized.
    

  /*  enum Days { Su,Mo,Tu,Wed,Thu,Fri,Sat};
    enum Months {Jan,Feb,Mar,Apr,May=50,Jun,Jul,Aug,Sep,Oct,Nov,Dec };*/
    
    public class Program : Class1
    {
        static void Main(string[] args)
        {

            /* Program p = new Program();  */
            /*c1.age;//Error if age is private*/
            /*c1.Walk();//Error if walk is private*/
            /*int i = c1.age;//OK as it public
            c1.Walk();//OK as it public*/
            /* int i = p.age;
             p.Walk();*/


            //Structs

            /* Game game1;*//*= new Game("Test","bips",4.5,"2024/11/21");*//*
             game1.name = "Test";
             game1.developer = "bips";
             game1.rating = 4.5;
             game1.releaseDate = "2024/11/21";

             game1.DisplayInfo();*/

            //Enums

            /* Days su = Days.Su;
             Days sun = Days.Su;
             Console.WriteLine(sun == su);
             Console.WriteLine(Days.Thu);
             int friday = (int)Days.Fri;
             Months may = Months.May;
             Console.WriteLine((int)Months.Oct);
             Console.WriteLine(friday);
 */
            //Math class

            /*Console.WriteLine("Ceiling of 3.3 is {0}",Math.Ceiling(3.3));
            Console.WriteLine("Floor of 3.3 is {0}",Math.Floor(3.3));

            int num1 = 2;
            int num2 = 4;
            Console.WriteLine("Lower between {0} and {1} is {2}",num1,num2,Math.Min(num1,num2));
            Console.WriteLine("Higher between {0} and {1} is {2}", num1, num2, Math.Max(num1, num2));
            Console.WriteLine("Power of 3 and 5 is {0}",Math.Pow(3,5));
            Console.WriteLine("Sqaure root of 25 is {0}",Math.Sqrt(25));
            Console.WriteLine("Absolute of -1 is {0}",Math.Abs(-1));
            Console.WriteLine("Cosine value of 0 is {0}", Math.Cos(1));
*/


            //Random 

            /* Random dice = new Random();
             int diceNumbers;
             for(int i = 0;i<10;i++)
             {
                 diceNumbers = dice.Next(1,7);
                 Console.WriteLine(diceNumbers);
             }*/

            /*  Random fortuneTeller = new Random();
              int fortuneTellerNumbers;
              Console.WriteLine("How many questions you wanna ask?");
              string Qns = Console.ReadLine();
              int numberOfQns;
              bool success = int.TryParse(Qns, out numberOfQns);
              Console.WriteLine($"Ok You may ask {numberOfQns} number of questions than...");
              if (success)
              {
                  for (int i = 0; i < numberOfQns; i++)
                  {
                      Console.WriteLine($"Ask your {i+1} question.");
                      Console.ReadLine();
                      fortuneTellerNumbers = fortuneTeller.Next(1, 4);
                      if (fortuneTellerNumbers == 1)
                      {
                          Console.WriteLine("Yes");
                      }
                      else if (fortuneTellerNumbers == 2)
                      {
                          Console.WriteLine("Maybe");
                      }
                      else
                      {
                          Console.WriteLine("No");
                      }

                  }
              }
              else
              {
                  Console.WriteLine("Please enter valid number of questions you wanna ask.");
              }*/


            //DateTime CLass

            /*DateTime dateTime = new DateTime( );
            Console.WriteLine("My birthday is {0}",dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow's date is {0}",tomorrow);
            Console.WriteLine(DateTime.Today.DayOfWeek);

            DateTime firstDayDate = GetFirstDayOfYear(2001);
            Console.WriteLine(firstDayDate);
            int days = DateTime.DaysInMonth(2000,2);
            Console.WriteLine("Days in feb 2000are {0}",days);
             days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in feb 2004 are {0}", days);
             days = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine("Days in feb 2024 are {0}", days);

            Console.WriteLine("Current Minute is {0}",DateTime.Now.Minute);
            Console.WriteLine("{0} o' clock and {1} minutes and {2} seconds",DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
            Console.WriteLine("Enter your birth date in format yyyy-mm-dd");
            string input = Console.ReadLine();
         
           if( DateTime.TryParse(input,out dateTime))
                {
                TimeSpan daysPassed = DateTime.Now.Subtract(dateTime);
                Console.WriteLine("Number of days passed since your birthday is {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("ENter your date correctly");

            }*/



            //Nullable
            // Nullable are those types that can be either Null or not Null;

            /*Nullable<int> num1 = null;
            int? num2 = 3;
            Int128? num3 = new Int128?();
            double? num4 = new Double?();
            double? num5 = 3.4;

            bool? isSunday = null;

            Console.WriteLine("Nullable numbers  are {0},{1},{2},{3},{4}",num1,num2,num3,num4,num5);
            Console.WriteLine("Nullable bool is {0}",isSunday);

            bool? isMale = null;

            if(isMale == true)
            {
                Console.WriteLine("Male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("No Gender");
            }

            //Converting nullables types into non nullable types

            double? num6 = null;
            double? num7 = 3.5;
            double num8;
            if(num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num7;
            }
            Console.WriteLine(num8);
            // shorter method of converting is null coalescing

            num8 = num6 ?? 3.4;
            Console.WriteLine(num8);
            num8 = num7 ?? 3.5;
            Console.WriteLine(num8);
          */
            if(args.Length == 0)
            {
                Console.WriteLine("Please provide arguments as this smart app uses args. Type help if you want to get more details.");

                Console.ReadKey();
                return;

            }
            if (args[0] == "help")
            {
                Console.WriteLine(".................Instructions.................");
                Console.WriteLine("use one of the following commands followed by two numbers");
                Console.WriteLine(" 'add' : to add 2 nums");
                Console.WriteLine(" 'sub' : to sub 2 nums");
                Console.WriteLine(".............................");

                Console.ReadKey();
                return;
            }

              if(args.Length != 3)
            {
                Console.WriteLine("Invalid arguments,please use the help command for instrucions.");
                Console.ReadKey();
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help for instructions.");
                Console.ReadKey();
                return;
            }
            switch(args[0])
            {
                case "add":
                    Console.WriteLine("Sum of {0} and {1} is {2}",num1,num2,num1+num2);
                    break;
                case "sub":
                    Console.WriteLine("Sub of {0} and {1} is {2}", num1, num2, num1 - num2);
                    break;
                default:
                    Console.WriteLine("Invalid argument.Press help for more info");
                    break;
            }







            Console.ReadKey();
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);   
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
    public class Class1
    {
        protected int age = 18;
        protected void Walk()
        {
            Console.WriteLine("I am walking.");
        }
    }
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name,string developer,double rating,string releaseDate)
        {
            this.name = name;   
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name of game is {0}",name);
            Console.WriteLine("Name of game developer is {0}",developer);
            Console.WriteLine("Rating of game is {0}",rating);
            Console.WriteLine("Release date of game is {0}",releaseDate);
        }

    }
}
