using System.Data;

namespace Making_Decisions
{
    internal class Program
    {
         static string username;
         static string password;
        static void Main(string[] args)
        {
            //Video no:-48,49,50

            /* Console.WriteLine("Enter temp in num");
             string tempAsString = Console.ReadLine();
             int temp;
             bool success = int.TryParse(tempAsString, out temp);
             if (success)
             {
                 if (temp < 10)
                 {
                     Console.WriteLine("take the bloody coat");

                 }
                 else if (temp == 10)
                 {

                     Console.WriteLine("It is 10 degree celcius");
                 }
                else
                 {
                     Console.WriteLine("it is cozy and warm");
                 }

             }
             else
             {
                 Console.WriteLine("Enter temp in correct format");
             }
            */

            //Video no:-51

            /* bool isAdmin = false;
             bool isRegistered = true;

             Console.WriteLine("Enter username");
             string username = Console.ReadLine();

             if(isRegistered)
             {
                 Console.WriteLine("Hi, there registered User.");
                 if(username != "")
                 {
                     Console.WriteLine("Hi there {0}",username);
                     if (username.Equals("admin"))
                     {
                         Console.WriteLine("Hi there admin");
                     }
                 }


             }*/
            //Video no:-52,53
            /*Register();
            Login();*/

            //Video no :-54
            /* int a=3;
             int b=3;
             Console.WriteLine("Enter operator");
             string op= Console.ReadLine();
             int x;
             switch(op)
                 {
                 case "+":
                     x = a + b;
                     Console.WriteLine("sum is "+x);
                     break;

                 case "-":
                     x= a - b;
                     Console.WriteLine("sub is "+x);
                     break;

                 default:
                     Console.WriteLine("Wrong operator");
                     break;

             }*/

            //VIdeo no :-57

            /* int temp = 10;
             string stateOfMatter;

             stateOfMatter = (temp < 0) ? "solid" : "liquid";
             Console.WriteLine("State of Matter is "+stateOfMatter);
             //Adding gas
             temp += 100;
             stateOfMatter = (temp > 100) ? "gas" : (temp < 0) ? "solid" : "liquid";
             Console.WriteLine("State of matter after adding 100 is "+stateOfMatter);*/

            //Video no:=58 Challenge

            Console.WriteLine("Enter temp");
            string tempAsString = Console.ReadLine();
            int temp;
            bool success= int.TryParse(tempAsString, out temp);
            if (success)
            {
                string message;
                message = temp <= 15 ? "it is too cold here" : temp >= 16 && temp <= 28 ? "it is ok" : temp > 28 ? "it is hot here":"";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Not a Valid Temp");
            }
            Console.ReadKey();

        }
        public static void Register()
        {
            Console.WriteLine("Enter name");
             username= Console.ReadLine();
            Console.WriteLine("Enter password");
             password = Console.ReadLine();
           
        }
        public static void Login()
        {
            Console.WriteLine("Enter username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("enter password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("login success");
                }
                else
                {
                    Console.WriteLine("login unsuccessfull");
                }


            }
            else
            {
                Console.WriteLine("wrong username");
            }
        }
        }
}