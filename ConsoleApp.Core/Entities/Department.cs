namespace ConsoleApp.Core.Entities;

public class Department
{
    static int _id;
    public int DepartmentId { get; }
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public int CompanyId { get; set; }
    public Department()
    {
        DepartmentId = _id;
        _id++;
        
    }
    public Department(string name,int employeeLimit):this()
    {
        Name = name;
        EmployeeLimit = employeeLimit;
    }
    
    public override string ToString()
    {
        return $"{DepartmentId} {Name}";
    }
}
