﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Model
{
    public interface IStudent
    {
        Student GetStudent(int id);
    }
}
