using ConsoleApp.Business.DTOs;
using ConsoleApp.Core.Entities;

namespace ConsoleApp.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeDto employee);
    void Remove(int id);
    void Update(int id,EmployeeDto employee);
    List<Employee> GetAll();
    Employee GetById(int id);
    Employee GetByName(string name);

}
