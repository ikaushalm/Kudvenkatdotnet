using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Model
{
    public class MockStudnent : IStudent
    {
        private List<Student> _Student;

        public MockStudnent()
        {
            _Student = new List<Student>()
            { new Student() { Id=1,Name="Manoj",FatherName="Manoj",Phone=7786} ,
            new Student() { Id=2,Name="Patel",FatherName="Manoj",Phone=7786} ,
            new Student() { Id=3,Name="Ranjana",FatherName="Manoj",Phone=7786} };

        }

        public Student GetStudent(int id)
        {
            return _Student.FirstOrDefault();
        }
    }
}
