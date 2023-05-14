namespace ConsoleApp.Core.Entities;
public class Employee
{
    static int _id;
    public int EmployeeId { get; }
    public decimal Salary { get; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int DepartmentId { get; }
    public Employee(int salary, string name, string surname)
    {
        EmployeeId = _id;
        _id++;
        Salary = salary;
        Name = name;
        SurName = surname;
    }
    public override string ToString()
    {
        return $"{EmployeeId} {Name} {SurName}";
    }
}
