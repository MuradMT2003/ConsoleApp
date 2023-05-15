namespace ConsoleApp.Business.Helpers;

public static class Helper
{
    public static Dictionary<string,string> errors=new Dictionary<string, string>()
    {
        {"NullDataException","You must give data" },
        {"MimimumIncome","You must give mimimum income to your employee" },
        {"LengthException","Your length is not match" },
        {"FormatException","You must  type data in correct format" },
        {"AlreadyExistException","DbContext already contains this data" },
        {"EmployeeLimitLackException","You are exceeded the employee limit"}

    };
}
