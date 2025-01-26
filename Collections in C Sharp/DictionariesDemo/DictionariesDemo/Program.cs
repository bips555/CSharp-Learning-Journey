namespace DictionariesDemo
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Employee[] empl = new Employee[5]
            {
                new Employee("Intern","Bips",23,1000),
                new Employee("CEO","Cips",60,10000),
                new Employee("Manager","Dips",30,3000),
                new Employee("CTO","Gips",49,7000),
                new Employee("Developer","Lips",34,4000)
            };
            Dictionary<int, string> mySimpleDictionary = new Dictionary<int, string>()
            {
               { 1, "One" },
               { 2, "Two" },
               { 3, "Three" }
            };

            Dictionary<string, Employee> myEmployeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee emp in empl)
            {
                myEmployeeDictionary.Add(emp.Role, emp);
            }
            Employee empl1 = myEmployeeDictionary["Intern"];
           /* Console.WriteLine("Employee Role: {0}",empl1.Role);
            Console.WriteLine("Employee Name: {0}", empl1.Name);
            Console.WriteLine("Employee Age: {0}", empl1.Age);
            Console.WriteLine("Employee Salary: {0}", empl1.Salary);*/
           string key = "CTO";
            /*   if(myEmployeeDictionary.ContainsKey(key))
              {
                  Employee empl2 = myEmployeeDictionary[key];
                  Console.WriteLine("ROle is {0} Name is {1} Age is {2} Salary is {3}",empl2.Role,empl2.Name,empl2.Age,empl2.Salary);
              }
              else
              {
                  Console.WriteLine("Doesnot contain {0}",key);
              }*/
            /*Employee empl3 = null;
            if (myEmployeeDictionary.TryGetValue(key, out empl3)) {
                Console.WriteLine("Result has been retrieved.");
                Console.WriteLine(empl3.Name);
            }
            else
            {
                Console.WriteLine("not retreived");
            }*/
            string keyToUpdate = "HR";
            if (myEmployeeDictionary.ContainsKey(key))
            {
                myEmployeeDictionary[keyToUpdate] = new Employee("HR", "tero tauko", 50, 0);
            }
            else
            {
                Console.WriteLine("Key doesnot exist",keyToUpdate);


            }
            if (myEmployeeDictionary.Remove(keyToUpdate))
            {
                Console.WriteLine("element was removed successfully");
            }
            else
            {
                Console.WriteLine("No such key found {0}",keyToUpdate);
            }
            for (int i = 0; i < myEmployeeDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = myEmployeeDictionary.ElementAt(i);
                Console.WriteLine("Key: {0}",keyValuePair.Key);
                Employee employee = keyValuePair.Value;
                Console.WriteLine("ROle is: {0}",employee.Role);
                Console.WriteLine("Name is: {0}", employee.Name);
                Console.WriteLine("Salary is: {0}", employee.Salary);
                Console.WriteLine("Age is: {0}", employee.Age);


            }

            Console.ReadKey();
        }
    }
}
