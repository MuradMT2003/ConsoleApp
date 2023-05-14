using ConsoleApp.Core.Entities;

namespace ConsoleApp.DataAccess.Contexts;
public static class DbContext
{
    public static List<Company> companies = new List<Company>();
    public static List<Employee> employees = new List<Employee>();
    public static List<Department> departments = new List<Department>();
}
