using ConsoleApp.Business.DTOs;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Helpers;
using ConsoleApp.Business.Interfaces;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Contexts;
using ConsoleApp.DataAccess.Implementations;

namespace ConsoleApp.Business.Services;

public class DepartmentService : IDepartmentService
{
    public DepartmentRepository departmentRepository { get;  }
    public EmployeeRepository employeeRepository { get; }
    public DepartmentService()
    {
        departmentRepository = new DepartmentRepository();
        employeeRepository = new EmployeeRepository();
    }
    public void Create(DepartmentDto department)
    {
        if (department == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        if (department.employeeLimit < 2)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if (department.name.Length < 2)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if (department.name.IsOnlyLetter() )
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        if (department.companyId < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        
        if (employeeRepository.GetAll().Count < department.employeeLimit)
        {
            throw new EmployeeLimitLackException(Helper.errors["EmployeeLimitLackException"]);
        }
        Department dep = new Department(department.name, department.employeeLimit,department.companyId);
        if (!departmentRepository.GetAll().Contains(dep))
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        departmentRepository.Add(dep);
    }

    public List<Department> GetAll()
    {
        var result = departmentRepository.GetAll();
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Department GetById(int id)
    {
        if (id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        var result = departmentRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Department GetByName(string name)
    {
        if (name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        var result = departmentRepository.GetByName(name);
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
        var result = departmentRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        departmentRepository.Delete(result);
    }

    public void Update(int id, DepartmentDto department)
    {
        if (id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if (department == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        if (employeeRepository.GetAll().Count < department.employeeLimit)
        {
            throw new EmployeeLimitLackException(Helper.errors["EmployeeLimitLackException"]);
        }
        var res = new Department(department.name, department.employeeLimit, department.companyId);
        if (departmentRepository.GetById(id) == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        departmentRepository.Update(id, res);
    }
}
