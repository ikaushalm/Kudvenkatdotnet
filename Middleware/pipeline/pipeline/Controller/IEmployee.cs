using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pipeline.Controller
{
    public interface IEmployee
    {
        Employee getEmployee(int id);
    }
}
