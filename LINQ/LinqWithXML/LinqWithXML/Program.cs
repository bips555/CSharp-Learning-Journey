using System.Xml;
using System.Xml.Linq;
namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                 @"<Students>
                      <Student>
                       <Name>Biplov</Name>
                       <Age>21</Age>
                       <University>TU</University>
                       <Semester>1st</Semester>
                      </Student>
                      <Student>
                       <Name>Samriddhi</Name>
                       <Age>24</Age>
                       <University>KU</University>
                       <Semester>2nd</Semester>
                      </Student>
                      <Student>
                       <Name>Laxmi</Name>
                       <Age>43</Age>
                       <University>PU</University>
                       <Semester>8th</Semester>
                      </Student>
                      <Student>
                       <Name>Hari</Name>
                       <Age>32</Age>
                       <University>PU</University>
                       <Semester>7th</Semester>
                      </Student>
                  </Students>";
            XDocument studentXDoc=  new XDocument();    
            studentXDoc= XDocument.Parse(studentsXML);

            var students = from student in studentXDoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
           

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} of age {1} in university {2} having {3} Semester",student.Name,student.Age,student.University,student.Semester);
            }
            Console.WriteLine("Students sorted with Age");
            var ageSortedStudents = from student in students
                                    orderby student.Age 
                                    select student;

            foreach(var student in ageSortedStudents)
            {
                Console.WriteLine("Student {0} of university {1} with age {2} having {3} Semester",student.Name,student.University,student.Age,student.Semester);
            }

        }
    }
}
