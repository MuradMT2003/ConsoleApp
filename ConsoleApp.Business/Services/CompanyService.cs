using ConsoleApp.Business.DTOs;
using ConsoleApp.Business.Exceptions;
using ConsoleApp.Business.Helpers;
using ConsoleApp.Business.Interfaces;
using ConsoleApp.Core.Entities;
using ConsoleApp.DataAccess.Implementations;
using System.Linq;

namespace ConsoleApp.Business.Services;

public class CompanyService : ICompanyService
{
    public CompanyRepository companyRepository { get; }
    public CompanyService()
    {
        companyRepository = new CompanyRepository();
    }
    public void Create(CompanyDto company)
    {
        if (company == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        
        if (company.name.Length < 2)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if (company.name.IsOnlyLetter() )
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        Company comp = new Company(company.name);
        if (!companyRepository.GetAll().Contains(comp))
        {
            throw new AlreadyExistException(Helper.errors["AlreadyExistException"]);
        }
        companyRepository.Add(comp);


    }

    public List<Company> GetAll()
    {
        var result = companyRepository.GetAll();
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Company GetById(int id)
    {
        if (id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        var result = companyRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        return result;
    }

    public Company GetByName(string name)
    {
        if (name.IsOnlyLetter())
        {
            throw new FormatException(Helper.errors["FormatException"]);
        }
        var result = companyRepository.GetByName(name);
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
        var result = companyRepository.GetById(id);
        if (result == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        companyRepository.Delete(result);
    }

    public void Update(int id, CompanyDto employee)
    {
        if (id < 0)
        {
            throw new LengthException(Helper.errors["LengthException"]);
        }
        if (employee == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        var res = new Company(employee.name);
        if (companyRepository.GetById(id) == null)
        {
            throw new NullDataException(Helper.errors["NullDataException"]);
        }
        companyRepository.Update(id, res);

    }
}
