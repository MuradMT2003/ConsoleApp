Console.WriteLine("Welcome to our application!");
while (true)
{
    Console.WriteLine("Please select your entity for operation:");
    Console.WriteLine("1.Employee");
    Console.WriteLine("2.Department");
    Console.WriteLine("3.Company");
    int entity=0;
    bool result= int.TryParse(Console.ReadLine(), out entity);
    switch (entity)
    {
        case (int)Entity.Employee:
            int operationemp = 0;
            Console.WriteLine("Please select your service for Employee:");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.GetAll");
            Console.WriteLine("5.GetById");
            Console.WriteLine("6.GetByName");
            bool resemp = int.TryParse(Console.ReadLine(), out operationemp);
            switch (operationemp)
            {
                case (int)Services.Create:

                    break;
                case (int)Services.Remove:

                    break;
                case (int)Services.Update:

                    break;
                case (int)Services.GetAll:

                    break;
                case (int)Services.GetById:

                    break;
                case (int)Services.GetByName:

                    break;
            }
            break;
        case (int)Entity.Department:
            int operationdep = 0;
            Console.WriteLine("Please select your service for Department:");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.GetAll");
            Console.WriteLine("5.GetById");
            Console.WriteLine("6.GetByName");
            bool resdep = int.TryParse(Console.ReadLine(), out operationdep);
            switch (operationdep)
            {
                case (int)Services.Create:

                    break;
                case (int)Services.Remove:

                    break;
                case (int)Services.Update:

                    break;
                case (int)Services.GetAll:

                    break;
                case (int)Services.GetById:

                    break;
                case (int)Services.GetByName:

                    break;
            }
            break;
        case (int)Entity.Company:
            int operationcom = 0;
            Console.WriteLine("Please select your service for Company:");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Remove");
            Console.WriteLine("3.Update");
            Console.WriteLine("4.GetAll");
            Console.WriteLine("5.GetById");
            Console.WriteLine("6.GetByName");
            bool rescom = int.TryParse(Console.ReadLine(), out operationcom);
            switch (operationcom)
            {
                case (int)Services.Create:

                    break;
                case (int)Services.Remove:

                    break;
                case (int)Services.Update:

                    break;
                case (int)Services.GetAll:

                    break;
                case (int)Services.GetById:

                    break;
                case (int)Services.GetByName:

                    break;
            }
            break;
        default:
            Console.WriteLine("Please enter only given number!");
            break;
    }

}
enum Entity
{
    Employee = 1,
    Department,
    Company
}
enum Services
{
    Create,
    Remove,
    Update,
    GetAll,
    GetById,
    GetByName
}

