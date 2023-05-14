using ConsoleApp.Core.Interfaces;

namespace ConsoleApp.Core.Entities;

public class Company:IEntity
{
    static int _id;
    public int CompanyId { get; }
    public string Name { get; set; }
    public Company()
    {
        CompanyId = _id;
        _id++;
    }
    public Company(string name):this()
    {
        Name = name;
    }

}
