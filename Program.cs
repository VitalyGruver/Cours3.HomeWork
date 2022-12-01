Console.Write("Введите имя пользователя: ");

string username = Console.ReadLine();

if (username.ToLower() == "маша")
    {
        Console.WriteLine("Приветик, Машуля!");
    }
else
    {
        Console.WriteLine("Привет, " + username + "!");
    }
