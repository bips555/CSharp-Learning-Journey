using System.Collections;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Hashtable studentHashtable = new Hashtable();
              Student stud1 = new Student(1, "bips", 99.9f);
              Student stud2 = new Student(2, "sips", 98.9f);
              Student stud3 = new Student(3, "dips", 97.9f);
              Student stud4 = new Student(4, "fips", 96.9f);
              studentHashtable.Add(stud1.Id, stud1);
              studentHashtable.Add(stud2.Id, stud2);
              studentHashtable.Add(stud3.Id, stud3);
              studentHashtable.Add(stud4.Id, stud4);
              Student storedStudent1 = (Student)studentHashtable[stud1.Id];
              Student storedStudent2 = (Student)studentHashtable[stud2.Id];
              Student storedStudent3 = (Student)studentHashtable[stud3.Id];
              Student storedStudent4 = (Student)studentHashtable[stud4.Id];
              Console.WriteLine("Student Id :{0} ,Student Name:{1} ,Student GPA:{2} ",storedStudent1.Id,storedStudent1.Name,storedStudent1.GPA);
              foreach(DictionaryEntry entry in studentHashtable)
              {
                  Student temp = (Student)entry.Value;
                  Console.WriteLine(temp.Id);
                  Console.WriteLine(temp.Name);
                  Console.WriteLine(temp.GPA);
              }
              foreach(Student value in  studentHashtable.Values)
              {
                  Console.WriteLine(value.Id);
                  Console.WriteLine(value.Name);
                  Console.WriteLine(value.GPA);
              }*/
            Student[] students = new Student[5];
            students[0] = new Student(1, "bips", 99.9f);
            students[0] = new Student(2, "dips", 95.9f);
            students[0] = new Student(6, "fips", 92.9f);
            students[0] = new Student(1, "gips", 91.9f);
            students[0] = new Student(4, "sips", 97.9f);
            Hashtable studentHt = new Hashtable();
            foreach(Student s in students)
                {
                if(!studentHt.ContainsKey(s.Id))
                {
                    studentHt.Add(s.Id, s);
                }
                else
                {
                    Console.WriteLine("Id should be unique");
                }

            }
            foreach (DictionaryEntry entry in studentHt)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("ID is {0}",temp.Id);

                Console.WriteLine("Name is {0}", temp.Name);
                
                Console.WriteLine("GPA is {0}", temp.GPA);
                

            }

            Console.ReadKey();
        }
    }
    
}
