using System.Security.Cryptography;

namespace LinqUniversityManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.AgeSortedStudents();
            um.StudentFromKUuniversity();
            Console.WriteLine("select id from university you want to show");
            um.StudentFromAllUniversity(int.Parse(Console.ReadLine()));
            int[] numbers = { 10, 13, 5, 4, 3 };
            IEnumerable<int> SortedNumbers = from number in numbers
                                             orderby number
                                             select number;
            IEnumerable<int> reverseSortedNumbers = SortedNumbers.Reverse();

            foreach (int number in reverseSortedNumbers)
            {
                Console.WriteLine(number);
            }

            reverseSortedNumbers = from number in numbers
                                   orderby number descending
                                   select number;


            foreach (int number in reverseSortedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();

        }
    }
    public class UniversityManager
    {
        List<University> universities;
        List<Student> students;

        public UniversityManager()
        {

            universities = new List<University>()
            {
                new University{Id = 1,Name="Kathmandu Univesity"},
                new University {Id=2,Name = "Tribhuwan University"}
            };

            students = new List<Student>()
            {
                new Student {Id=1,Name="Bips",Age=21,Gender="Male",UniversityId = 1 },
                 new Student {Id=2,Name="Sam",Age=24,Gender="Female",UniversityId = 1 },
                  new Student {Id=3,Name="CLoe",Age=22,Gender="Female",UniversityId = 2 },
                   new Student {Id=4,Name="Mark",Age=20,Gender="Male",UniversityId = 2 },
                    new Student {Id=5,Name="Kylie",Age=24,Gender="Female",UniversityId = 2 },


            };

        }
        public void MaleStudents()
        {
            IEnumerable<Student> MaleStudents = from student in students
                                                where student.Gender == "Male"
                                                select student;
            Console.WriteLine("Male Students");
            foreach (Student student in MaleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> FemaleStudents = from student in students
                                                  where student.Gender == "Female"
                                                  select student;
            Console.WriteLine("Female Students");
            foreach (Student student in FemaleStudents)
            {
                student.Print();
            }
         


        }
        public void AgeSortedStudents()
        {
            Console.WriteLine("Students sorted by age");

            IEnumerable<Student> ageSortedStudents = from student in students
                                                     orderby student.Age descending
                                                     select student;
            foreach (Student student in ageSortedStudents)
            {
                student.Print();
            }

        }
        public void StudentFromKUuniversity()
        {
            Console.WriteLine("Students from KU university");
            IEnumerable<Student> studentsFromKU = from student in students
                                                  join university in universities on student.UniversityId equals university.Id
                                                  where university.Name == "Kathmandu Univesity"
                                                  select student;
            foreach (Student student in studentsFromKU)
            {
                student.Print();
            }

        }
        public void StudentFromAllUniversity(int Id)
        {
            Console.WriteLine("Students from Id {0} university", Id);
            IEnumerable<Student> studentsFromUniversity = from student in students
                                                          join university in universities on student.UniversityId equals university.Id
                                                          where university.Id == Id
                                                          select student;

            foreach (Student student in studentsFromUniversity)
            {
                {
                    student.Print();
                }

            }
        }


        public class University
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Print()
            {
                Console.WriteLine("University {0} with Id {1}", Name, Id);
            }

        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }

            //Foreign Key

            public int UniversityId { get; set; }

            public void Print()
            {

                Console.WriteLine("Student {0} with Id {1} age {2} gender {3} and university Id {4}", Name, Id, Age, Gender, UniversityId);
            }

        }
    }
}