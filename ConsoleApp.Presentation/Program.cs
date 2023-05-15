using ConsoleApp.Business.DTOs;
using ConsoleApp.Business.Interfaces;
using ConsoleApp.Business.Services;
using ConsoleApp.Core.Enums;
using System;

Console.WriteLine("Welcome to our application!");
while (true)
{
    #region MainPart
    Console.WriteLine("Please select your entity for operation:");
    Console.WriteLine("1.Employee");
    Console.WriteLine("2.Department");
    Console.WriteLine("3.Company");
    int entity = 0;
    bool result = int.TryParse(Console.ReadLine(), out entity);
    #endregion
    switch (entity)
    {
        #region EmployeeService
        case (int)Entity.Employee:
            #region EmployeeServiceIntro
            int operationemp = 0;
            Console.WriteLine("Please select your service for Employee:");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.GetAll");
            Console.WriteLine("5.GetById");
            Console.WriteLine("6.GetByName");
            bool resemp = int.TryParse(Console.ReadLine(), out operationemp);
            #endregion
            switch (operationemp)
            {
                #region EmployeeServiceCreate
                case (int)Services.Create:
                    try
                    {
                        Console.Write("Please enter employee salary:");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        Console.Write("Please enter employee name:");
                        string name = Console.ReadLine();
                        Console.Write("Please enter employee surname:");
                        string surname = Console.ReadLine();
                        Console.Write("Please enter employee department id:");
                        int depid = int.Parse(Console.ReadLine());
                        EmployeeService empscreate = new EmployeeService();
                        EmployeeDto employeeDto = new(salary, name, surname, depid);
                        empscreate.Create(employeeDto);
                        Console.WriteLine("Succesfully added employee!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                    break;
                #endregion
                #region EmployeeServiceRemove
                case (int)Services.Remove:
                    try
                    {
                        Console.Write("Please enter employee  id for removing:");
                        int idcrt = int.Parse(Console.ReadLine());
                        EmployeeService empsremove = new EmployeeService();
                        empsremove.Remove(idcrt);
                        Console.WriteLine("Your employee removed succesfully!");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region EmployeeServiceUpdate
                case (int)Services.Update:
                    try
                    {
                        Console.Write("Please enter employee  id for updating:");
                        int idupdt = int.Parse(Console.ReadLine());
                        Console.Write("Please enter employee salary:");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        Console.Write("Please enter employee name:");
                        string name = Console.ReadLine();
                        Console.Write("Please enter employee surname:");
                        string surname = Console.ReadLine();
                        Console.Write("Please enter employee department id:");
                        int depid = int.Parse(Console.ReadLine());
                        EmployeeService empscreate = new EmployeeService();
                        EmployeeDto employeeDto = new(salary, name, surname, depid);
                        empscreate.Update(idupdt,employeeDto);
                        Console.WriteLine("Succesfully updated employee!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region EmployeeServiceGetAll
                case (int)Services.GetAll:
                    try
                    {
                        Console.WriteLine("Employees List:");
                        EmployeeService empsgetall = new EmployeeService();
                        foreach (var item in empsgetall.GetAll())
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region EmployeeServiceGetById
                case (int)Services.GetById:
                    try
                    {
                        Console.WriteLine("Please enter id for your Employee:");
                        int id;
                        bool resempid = int.TryParse(Console.ReadLine(), out id);
                        EmployeeService empsgetid = new EmployeeService();
                        Console.WriteLine(resempid ? $"Your Employee is:{empsgetid.GetById(id).Name+" "+empsgetid.GetById(id).SurName ?? "There is not given employee!"}"
                            : "You must give id in true format!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region EmployeeServiceGetByName
                case (int)Services.GetByName:
                    try
                    {
                        Console.WriteLine("Please enter your Employee name:");
                        string name=Console.ReadLine();
                        EmployeeService empsgetname = new EmployeeService();
                        Console.WriteLine(name!=null?
                            $"Your Employee is:{empsgetname.GetByName(name).Name + " " + empsgetname.GetByName(name).SurName}"
                            :"You data is empty!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                    #endregion
            }
            break;
        #endregion
        #region DepartmentServices
        case (int)Entity.Department:
            #region DepartmentServiceIntro
            int operationdep = 0;
            Console.WriteLine("Please select your service for Department:");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.GetAll");
            Console.WriteLine("5.GetById");
            Console.WriteLine("6.GetByName");
            bool resdep = int.TryParse(Console.ReadLine(), out operationdep);
            #endregion
            switch (operationdep)
            {
                #region DepartmentServiceCreate
                case (int)Services.Create:
                    try
                    {
                        Console.Write("Please enter department name:");
                        string name = Console.ReadLine();
                        Console.Write("Please enter department employeeLimit:");
                        int employeelimit = int.Parse(Console.ReadLine());
                        Console.Write("Please enter department company Id:");
                        int compid = int.Parse(Console.ReadLine());
                        DepartmentService depscreate = new DepartmentService();
                        DepartmentDto departmentDto = new(name, employeelimit, compid);
                        depscreate.Create(departmentDto);
                        Console.WriteLine("Succesfully added department!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                #endregion
                #region DepartmentServiceRemove
                case (int)Services.Remove:
                    try
                    {
                        Console.Write("Please enter department  id for removing:");
                        int idrmv = int.Parse(Console.ReadLine());
                        DepartmentService depsremove = new DepartmentService();
                        depsremove.Remove(idrmv);
                        Console.WriteLine("Your department removed succesfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region DepartmentServiceUpdate
                case (int)Services.Update:
                    try
                    {
                        Console.Write("Please enter department  id for updating:");
                        int idupd = int.Parse(Console.ReadLine());
                        Console.Write("Please enter department name:");
                        string name = Console.ReadLine();
                        Console.Write("Please enter department employeeLimit:");
                        int employeelimit = int.Parse(Console.ReadLine());
                        Console.Write("Please enter department company Id:");
                        int compid = int.Parse(Console.ReadLine());
                        DepartmentService depsupdate = new DepartmentService();
                        DepartmentDto departmentDto = new(name, employeelimit, compid);
                        depsupdate.Update(idupd, departmentDto);
                        Console.WriteLine("Succesfully updated department!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region DepartmentServiceGetAll
                case (int)Services.GetAll:
                    try
                    {
                        Console.WriteLine("Departments List:");
                        DepartmentService depsgetall = new DepartmentService();
                        foreach (var item in depsgetall.GetAll())
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region DepartmentServiceGetById
                case (int)Services.GetById:
                    try
                    {
                        Console.WriteLine("Please enter id for your Department:");
                        int id;
                        bool resdepid = int.TryParse(Console.ReadLine(), out id);
                        DepartmentService depsgetid = new DepartmentService();
                        Console.WriteLine(resdepid ? $"Your Department is:{depsgetid.GetById(id).Name?? "There is not given department!"}"
                            : "You must give id in true format!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region DepartmentServiceGetByName
                case (int)Services.GetByName:
                    try
                    {
                        Console.WriteLine("Please enter your Department name:");
                        string name = Console.ReadLine();
                        DepartmentService depsgetname = new DepartmentService();
                        Console.WriteLine(name != null ?
                            $"Your Department is:{depsgetname.GetByName(name).Name}"
                            : "You data is empty!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                    #endregion
            }
            break;
        #endregion
        #region CompanyServices
        case (int)Entity.Company:
            #region CompanyServiceIntro
            int operationcom = 0;
            Console.WriteLine("Please select your service for Company:");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.GetAll");
            Console.WriteLine("5.GetById");
            Console.WriteLine("6.GetByName");
            bool rescom = int.TryParse(Console.ReadLine(), out operationcom);
            #endregion
            switch (operationcom)
            {
                #region CompanyServiceCreate
                case (int)Services.Create:
                    try
                    {
                        Console.Write("Please enter company name:");
                        string name = Console.ReadLine();
                        CompanyService compscreate = new CompanyService();
                        CompanyDto companyDto = new(name);
                        compscreate.Create(companyDto);
                        Console.WriteLine("Succesfully added company!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region CompanyServiceRemove
                case (int)Services.Remove:
                    try
                    {
                        Console.Write("Please enter company id for removing:");
                        int idrmv = int.Parse(Console.ReadLine());
                        CompanyService compsremove = new CompanyService();
                        compsremove.Remove(idrmv);
                        Console.WriteLine("Your company removed succesfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region CompanyServiceUpdate
                case (int)Services.Update:
                    try
                    {
                        Console.Write("Please enter company id for removing:");
                        int idupd = int.Parse(Console.ReadLine());
                        Console.Write("Please enter company name:");
                        string name = Console.ReadLine();
                        CompanyService compsupdate = new CompanyService();
                        CompanyDto companyDto = new(name);
                        compsupdate.Update(idupd,companyDto);
                        Console.WriteLine("Succesfully updated company!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region CompanyServiceGetAll
                case (int)Services.GetAll:
                    try
                    {
                        Console.WriteLine("Companies List:");
                        CompanyService compsgetall = new CompanyService();
                        foreach (var item in compsgetall.GetAll())
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region CompanyServiceGetById
                case (int)Services.GetById:
                    try
                    {
                        Console.WriteLine("Please enter id for your Company:");
                        int id;
                        bool resdepid = int.TryParse(Console.ReadLine(), out id);
                        CompanyService compsgetid = new CompanyService();
                        Console.WriteLine(resdepid ? $"Your Company is:{compsgetid.GetById(id).Name ?? "There is not given Company!"}"
                            : "You must give id in true format!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                #endregion
                #region CompanyServiceByName
                case (int)Services.GetByName:
                    try
                    {
                        Console.WriteLine("Please enter your Company name:");
                        string name = Console.ReadLine();
                        CompanyService compsgetname = new CompanyService();
                        Console.WriteLine(name != null ?
                            $"Your Company is:{compsgetname.GetByName(name).Name}"
                            : "You data is empty!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                    #endregion
            }
            break;
        #endregion
        #region Default
        default:
            Console.WriteLine("Please enter only given number!");
            break;
            #endregion
    }
    #region ProgramContinueLogic
    int contprog;
    bool contprogres;
    while (true)
    {
        Console.WriteLine("Do you want continue your program?");
        Console.WriteLine("Please select 0 for closing your program or 1 to proceed application!");
        contprogres = int.TryParse(Console.ReadLine(), out contprog);
        if(contprogres&&contprog==0||contprog==1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter one of the given numbers!");
        }
    }
    
    if (contprogres)
    {
        if(contprog==0) 
        {
            Console.WriteLine("Thanks for using our application!");
            break;
        }
        else if(contprog==1)
        {
            continue;
        }
        
    }
    #endregion
}
