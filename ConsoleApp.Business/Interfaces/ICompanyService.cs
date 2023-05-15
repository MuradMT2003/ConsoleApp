using ConsoleApp.Business.DTOs;
using ConsoleApp.Core.Entities;

namespace ConsoleApp.Business.Interfaces
{
    public interface ICompanyService
    {
        void Create(CompanyDto company);
        void Remove(int id);
        void Update(int id, CompanyDto company);
        List<Company> GetAll();
        Company GetById(int id);
        Company GetByName(string name);
    }
}
