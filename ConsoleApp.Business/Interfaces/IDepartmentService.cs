using ConsoleApp.Business.DTOs;
using ConsoleApp.Core.Entities;

namespace ConsoleApp.Business.Interfaces;

public interface IDepartmentService
{
    void Create(DepartmentDto department);
    void Remove(int id);
    void Update(int id, DepartmentDto department);
    List<Department> GetAll();
    Department GetById(int id);
    Department GetByName(string name);
}
