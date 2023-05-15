using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Contexts;

namespace ConsoleApp.DataAccess.Implementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DbContext.departments.Add(entity);
    }

    public void Delete(Department entity)
    {
        DbContext.departments.Remove(entity);
    }

    public List<Department>? GetAll()
    {
        return DbContext.departments;
    }

    public Department? GetById(int id)
    {
        return DbContext.departments.Find(p=>p.DepartmentId==id);
    }

    public Department? GetByName(string name)
    {
        return DbContext.departments.Find(p=>p.Name==name);
    }

    public void Update(int id,Department entity)
    {
        var findedEntity= DbContext.departments.Find(p=>p.DepartmentId==id);
        
            findedEntity.Name = entity.Name;
            findedEntity.EmployeeLimit = entity.EmployeeLimit;
            findedEntity.CompanyId = entity.CompanyId;
        
    }
}
