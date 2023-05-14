using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Contexts;

namespace ConsoleApp.DataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
        DbContext.employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        DbContext.employees.Remove(entity);
    }

    public List<Employee>? GetAll()
    {
        return DbContext.employees;
    }

    public Employee? GetById(int id)
    {
        return DbContext.employees.Find(x => x.EmployeeId == id);
    }

    public Employee? GetByName(string name)
    {
        return DbContext.employees.Find(x => x.Name == name);
    }

    public void Update(Employee entity)
    {
        var findedEntity = DbContext.employees.Find(x => x.EmployeeId == entity.EmployeeId);
        if (findedEntity != null)
        {
            findedEntity.Name = entity.Name;
            findedEntity.SurName = entity.SurName;
            findedEntity.DepartmentId = entity.DepartmentId;
            findedEntity.Salary = entity.Salary;
        }
    }
}
