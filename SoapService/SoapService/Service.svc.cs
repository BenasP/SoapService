using System.Collections.Generic;
using System.Linq;

namespace SoapService
{
    public class Service : IService
    {
        private static readonly List<Student> students = new List<Student>();

        public Student GetStudent(string searchParam)
        {
            return students.FirstOrDefault(x => x.FirstName.Contains(searchParam)
                                                || x.LastName.Contains(searchParam)
                                                || x.Id.Contains(searchParam));
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddUpdateStudent(Student student)
        {
            var indexOfStudent = students.FindIndex(x => x.Id == student.Id);

            if (indexOfStudent != -1)
            {
                students[indexOfStudent] = student;
                return;
            }

            students.Add(student);
        }
    }
}
