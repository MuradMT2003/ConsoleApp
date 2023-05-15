using ConsoleApp.Business.DTOs;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Helpers;
using ConsoleApp.Business.Interfaces;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Contexts;
using ConsoleApp.DataAccess.Implementations;

namespace ConsoleApp.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository  employeeRepository { get; }
    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();
    }
    public void Create(EmployeeDto employee)
    {
        if(employee == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        if (employee.salary < 300)
        {
            throw new MinimumIncomeException(Helper.errors["MinimumIncomeException"]);
        }
        if(employee.name.Length < 2)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if(employee.name.IsOnlyLetter()&& employee.surName.IsOnlyLetter() ) 
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        Employee emp = new Employee(employee.salary, employee.name, employee.surName, employee.departmentId);
        if (!employeeRepository.GetAll().Contains(emp))
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);    
        }
        employeeRepository.Add(emp);


    }

    public List<Employee> GetAll()
    {
        var result = employeeRepository.GetAll() ;
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Employee GetById(int id)
    {
        if(id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        var result = employeeRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Employee GetByName(string name)
    {
        if (name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        var result = employeeRepository.GetByName(name);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public void Remove(int id)
    {
        if (id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        var result = employeeRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        employeeRepository.Delete(result);
    }

    public void Update(int id, EmployeeDto employee)
    {
        if (id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if (employee == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        var res = new Employee(employee.salary, employee.name, employee.surName, employee.departmentId);
        if (employeeRepository.GetById(id) == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        employeeRepository.Update(id,res);

    }
}
