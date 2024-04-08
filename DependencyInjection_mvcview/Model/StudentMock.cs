using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_mvcview.Model
{
    public class StudentMock : IStudent
    {
        private List<Student> _student;

        public StudentMock()
        {
            _student = new List<Student>() 
            {
                new Student() {Id=1,Name="Kauhsal",Subject="Maths" },
                new Student() {Id=2,Name="Kauhsal3",Subject="Maths3" },
                new Student() {Id=3,Name="Kauhsal2",Subject="Maths2" },
                new Student() {Id=4,Name="Kauhsal1",Subject="Maths1" }
            };
        }

        public Student GetStudent(int id)
        {
            return _student.FirstOrDefault(x => x.Id == id);
           
        }
    }
}
