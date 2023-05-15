using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.Core.Entities;

public class Department:IEntity
{
    static int _id=1;
    public int DepartmentId { get; }
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public int CompanyId { get; set; }
    public Department()
    {
        DepartmentId = _id;
        _id++;
        
    }
    public Department(string name,int employeeLimit,int companyId):this()
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        CompanyId = companyId;
    }
    
    public override string ToString()
    {
        return $"{DepartmentId} {Name}";
    }
}
