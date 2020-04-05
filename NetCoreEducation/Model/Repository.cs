using System.Collections.Generic;

namespace NetCoreEducation.Model
{
    public static class Repository
    {
        private static List<Student> _students = new List<Student>();

        public static List<Student> Students
        {
            get => _students;
            set => _students = value;
        }

        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}