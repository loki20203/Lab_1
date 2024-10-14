using System;
using MyApp.Models;

class Program
{
    static void Main()
    {
        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        Console.Write("Введіть ім'я: ");
        string firstName = Console.ReadLine();

        Console.Write("Введіть прізвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть вік: ");
        int age = Convert.ToInt32(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);

        Console.WriteLine("\nІнформація про користувача:");
        user.DisplayInfo();
    }
}
