using System;



partial class Program {
    public static void Main()
    {
        User People1 = new User();
        People1.Name = "Ваня";
        People1.ID = 1;
        People1.Surname = "Петров";
        People1.Age = 20;
        People1.Login = "vanya01";
        People1.Password = "12456";
        Console.WriteLine("ID: " + People1.ID);
        Console.WriteLine("Имя: " + People1.Name);
        Console.WriteLine("Фамилия: " + People1.Surname);
        Console.WriteLine("Возраст: " + People1.Age);
        Console.WriteLine("Логин: " + People1.Login);
        Console.WriteLine("Пароль: " + People1.Password);
    }

class User
    {
        public int ID = 0;
        public string Name = "";
        public string Surname = "";
        public int Age = 0;
        public string Login = "";
        public string Password = "";

    }
}

