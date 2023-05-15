using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Contexts;

namespace ConsoleApp.DataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{
    public void Add(Company entity)
    {
        DbContext.companies.Add(entity);    
    }

    public void Delete(Company entity)
    {
        DbContext.companies.Remove(entity);
    }

    public List<Company>? GetAll()
    {
        return DbContext.companies;
    }

    public Company? GetById(int id)
    {
        return DbContext.companies.Find(p => p.CompanyId == id);
    }

    public Company? GetByName(string name)
    {
        return DbContext.companies.Find(p => p.Name == name);
    }

    public void Update(int id, Company entity)
    {
        var findedEntity= DbContext.companies.Find(p => p.CompanyId == id);
        if(findedEntity != null)
        {
            findedEntity.Name = entity.Name;
        }
          
    }
}
