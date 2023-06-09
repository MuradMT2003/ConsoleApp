﻿using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.Core.Entities;
public class Employee:IEntity
{
    static int _id=1;
    public int EmployeeId { get; }
    public decimal Salary { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int DepartmentId { get; set; }
    public Employee(decimal salary, string name, string surname)
    {
        EmployeeId = _id;
        _id++;
        Salary = salary;
        Name = name;
        SurName = surname;
    }
    public Employee(decimal salary, string name, string surname,int departmentId):this(salary, name, surname)
    {
        DepartmentId = departmentId;
    }
    public override string ToString()
    {
        return $"{EmployeeId} {Name} {SurName}";
    }
}
