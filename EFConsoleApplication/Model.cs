using System;

namespace EFConsoleApplication
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }

    }

    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
