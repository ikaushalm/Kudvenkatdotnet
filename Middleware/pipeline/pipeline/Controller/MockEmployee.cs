using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pipeline.Controller
{
    public class MockEmployee : IEmployee
    {
        private List<Employee> _em;

        public MockEmployee()
        {
            _em = new List<Employee>() { 
                new Employee() { Name = "Kaushal", Age = 23, ID = 1 } ,
                new Employee() { Name = "kau", Age = 23, ID = 2 }, 
                new Employee() { Name = "Kaushal3", Age = 23, ID = 3 } 
            };
        }

        public Employee getEmployee(int id)
        {
            return _em.FirstOrDefault(x => x.ID == id);
        }
    }
}
