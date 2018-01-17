using System;
//using System.Data.Entity;
using System.Linq;

namespace EFConsoleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                //AddStudentRecords();   // student
                //ReadRecords();  // student
                //AddCourse();    // course

                //UpdateStudentRecordById(1);

                ReadStudentRecordById(2);
                //DeleteStudentRecordById(2);
                //ReadRecords();  // student

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                Console.ReadLine();
            }
            Console.WriteLine("Person Saved");
            Console.ReadLine();
        }

        public static void AddStudentRecords()
        {
            using (var db = new UniversityDBContext())
            {
                var student = new Student 
                {
                    FirstName = "Hank",
                    LastName = "Clinton",
                    BirthDay = DateTime.Now
                };
                db.Students.Add(student);

                student = new Student 
                {
                    FirstName = "Dan",
                    LastName = "Trump",
                    BirthDay = DateTime.Now
                };
                db.Students.Add(student);

                db.SaveChanges();
            }
        }

        public static void AddCourse()
        {
            using (var db = new UniversityDBContext())
            {
                var course = new  Course
                {
                    Name = "Math"
                };
                db.Courses.Add(course);
                db.SaveChanges();
            }
        }

        public static void ReadRecords()
        {
            using (var db = new UniversityDBContext())
            {
                var students = db.Students;

                foreach (var row in students)
                    Console.WriteLine(row.FirstName + " " + row.LastName + " DOB: " + row.BirthDay);
            }
        }
        public static void ReadStudentRecordById(int id)
        {
            using (var db = new UniversityDBContext())
            {
                var selected_rcd = db.Students.FirstOrDefault(d => d.StudentId == id);
                Console.WriteLine("Name " + selected_rcd.FirstName + " " + selected_rcd.LastName);

                //var last_name = db.Students.Where(c => c.LastName.StartsWith("D"));
                //foreach (var s in last_name)
                //    Console.WriteLine(s.FirstName + " " + s.LastName);
            }
        }

        public static void UpdateStudentRecordById(int id)
        {
            using (var db = new UniversityDBContext())
            {
                var selected_rcd = db.Students.FirstOrDefault(d => d.StudentId == id);
                selected_rcd.LastName = "Dawadi";
                
                db.SaveChanges();
            }
        }

        public static void DeleteStudentRecordById(int id)
        {
            using (var db = new UniversityDBContext())
            {
                var selected_rcd = db.Students.FirstOrDefault(d => d.StudentId == id);
                db.Students.Remove(selected_rcd);
                db.SaveChanges();
            }
        }



    }
}
