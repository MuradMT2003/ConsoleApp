﻿namespace ConsoleApp.Business.Exceptions;

public class CapacityLimitException:Exception
{
    public CapacityLimitException(string message):base(message)
    {
        
    }
}
