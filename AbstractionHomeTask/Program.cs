using AbstractionHomeTask;

User[] users = new User[3];
for (int i = 0; i < users.Length; i++)
{
    while (true)
    {
        try
        {
            Console.Write("Enter Fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            users[i] = new User(fullname, email, password);
            break;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Menu:");
        Console.WriteLine("1. Butun Telebeler ");
        Console.WriteLine("2. Id ile tap");
        Console.WriteLine("0. Son");
        Console.Write("Bir Nomre Sec: ");

        if (int.TryParse(Console.ReadLine(), out int nomre))
        {
            if (nomre == 0)
            {
                break;
            }
            else if (nomre == 1)
            {
                foreach (var user in users)
                {
                    user.GetInfo();
                }
            }
            else if (nomre == 2)
            {
                Console.Write("Enter ID: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    User.FindUserById(id, users);
                }
                else
                {
                    Console.WriteLine("Yanlish ID duz number daxil et");
                }
            }
            else
            {
                Console.WriteLine("Yanlish secim   bir daha cəhd et");
            }
        }
        else
        {
            Console.WriteLine("Yalnish daxiletmə ...duz  number daxil et.");
        }
    }

}

