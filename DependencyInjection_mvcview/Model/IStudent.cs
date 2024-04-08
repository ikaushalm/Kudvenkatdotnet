using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_mvcview.Model
{
     public interface IStudent
    {
        Student GetStudent(int id);
    }
}
