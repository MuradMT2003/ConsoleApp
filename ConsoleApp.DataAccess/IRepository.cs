using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.DataAccess;

public interface IRepository<T> where T : class,IEntity 
{
    void Add(T entity);
    void Update(int id,T entity);
    void Delete(T entity);
    T? GetById(int id);
    List<T>? GetAll();
    T? GetByName(string name);
}
