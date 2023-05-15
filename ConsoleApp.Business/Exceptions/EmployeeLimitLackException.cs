namespace ConsoleApp.Business.Exceptions;

public class EmployeeLimitLackException:Exception
{
    public EmployeeLimitLackException(string message):base(message)
    {
        
    }
}
