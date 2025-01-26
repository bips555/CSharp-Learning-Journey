using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Xml.Linq;
using System.Data.Linq;

namespace LinqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlClassesDataDataContext dataContext;
        
        public MainWindow()
        {
            InitializeComponent();
            string ConnectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.BipsDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlClassesDataDataContext(ConnectionString);
            /*InsertUniversities();*/
            /*InsertStudents();*/
            /*InsertLectures();*/
            /*InsertStudentLectureAssociations();*/
            /*GetUniversityOfBips();*/
            /*            GetLecturesFromSam();*/
            /*            GetAllStudentsFromKU();
            */
            GetAllUniversitiesWithTransGenders();

            /*            GetAllLecturesFromKU();
            */
            /*            UpdateBips();
            */
            /*DeleteBips();*/
        }
        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            University KU = new University();
            KU.Name = "Kathmandu University";
            University TU =  new University();
            TU.Name = "Tribhuwan University";
            dataContext.Universities.InsertOnSubmit(KU);
            dataContext.Universities.InsertOnSubmit(TU);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Universities;
        }
        public void InsertStudents()
        {
            dataContext.ExecuteCommand("delete from Students");
            University KU = dataContext.Universities.First(un => un.Name == "Kathmandu University");
            University TU = dataContext.Universities.First(un => un.Name == "Tribhuwan University");
            List<Student> students  =new List<Student>();
            students.Add(new Student {Name="Bips",Gender = "Male",UniversityId = KU.Id});
            students.Add(new Student {Name="Sam",Gender="Female",UniversityId=TU.Id});
            students.Add(new Student {Name = "Sakar", Gender = "Trans-Gender", UniversityId = TU.Id});
            students.Add(new Student {Name="Sahal",Gender = "Male",UniversityId=KU.Id });
            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Science" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;

        }
        public void InsertStudentLectureAssociations()
        {
            Student Bips = dataContext.Students.First(st => st.Name == "Bips");
            Student Sam = dataContext.Students.First(st => st.Name == "Sam");
            Student Sakar = dataContext.Students.First(st => st.Name == "Sakar");
            Student Sahal = dataContext.Students.First(st => st.Name == "Sahal");

            Lecture Math = dataContext.Lectures.First(le => le.Name == "Math");
            Lecture Science = dataContext.Lectures.First(le => le.Name == "Science");
            Lecture History = dataContext.Lectures.First(le => le.Name == "History");

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = Bips.Id, LectureId = Math.Id });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = Bips.Id, LectureId = Science.Id });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = Sam.Id, LectureId = History.Id });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = Sahal.Id, LectureId = Science.Id });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { StudentId = Sakar.Id, LectureId = Math.Id });
            
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }
        public void GetUniversityOfBips()
        {
            Student bips = dataContext.Students.First(st => st.Name == "Bips");
            University bipsUniversity = bips.University;
            List<University> universities = new List<University>();
            universities.Add(bipsUniversity);
            MainDataGrid.ItemsSource = universities;
        }
        public void GetLecturesFromSam()
        {
            Student Sam = dataContext.Students.First(st => st.Name == "Sam");
            var samLectures = from sl in Sam.StudentLectures select sl;
            MainDataGrid.ItemsSource = samLectures;
        }
        public void GetAllStudentsFromKU()
        {
            University KU = dataContext.Universities.First(un => un.Name == "Kathmandu University");
            var kuStudents = from students in KU.Students select students;
            MainDataGrid.ItemsSource = kuStudents;
        }
        public void GetAllUniversitiesWithTransGenders()
        {
            var universitiesWithTransGenders = from students in dataContext.Students
                                               join universities in dataContext.Universities on students.UniversityId equals universities.Id
                                               where students.Gender == "Trans-Gender"
                                               select universities;
            MainDataGrid.ItemsSource = universitiesWithTransGenders;
                                               
        }
        public void GetAllLecturesFromKU()
        {
            var lecturesFromKu = from sl in dataContext.StudentLectures
                                 join student in dataContext.Students on sl.StudentId equals student.Id
                                 where student.University.Name == "Kathmandu University"
                                 select sl.Lecture;
            MainDataGrid.ItemsSource = lecturesFromKu;
        }
        public void UpdateBips()
        {
            Student bips = dataContext.Students.FirstOrDefault(st => st.Name == "Bips");
            bips.Name = "Biplove";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;

        }
        public void DeleteBips()
        {
            Student bips = dataContext.Students.FirstOrDefault(st => st.Name == "Biplove");
            dataContext.Students.DeleteOnSubmit(bips);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
