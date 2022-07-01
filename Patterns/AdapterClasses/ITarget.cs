using System;
namespace Patterns.AdapterClasses;

public interface ITarget
    {
        void ProcessSalary(string[,] employeesArray);
    }