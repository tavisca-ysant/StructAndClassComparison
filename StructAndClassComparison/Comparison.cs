using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace StructAndClassComparison
{
    [MemoryDiagnoser]
    public partial class Comparison
    {
        private Employee _employee;

        [GlobalSetup]
        public void Setup()
        {
            _employee = new Employee(1, "yatharth", "sw dev");
        }

        [Benchmark]
        public void Struct()
        {
            EmployeeStruct employeeStruct = new EmployeeStruct();
            employeeStruct.Id = _employee.Id;
            employeeStruct.Name = _employee.Name;
            employeeStruct.Designation = _employee.Designation;

        }

        [Benchmark]
        public void Class()
        {
            EmployeeClass employeeClass = new EmployeeClass();
            employeeClass.Id = _employee.Id;
            employeeClass.Name = _employee.Name;
            employeeClass.Designation = _employee.Designation;

        }

    }
}
