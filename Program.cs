using System;

namespace AddressApp
{
    class Address
    {
        // Поля класу
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        // Конструктор
        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        // Властивості (методи доступу)
        public string Index { get { return index; } }
        public string Country { get { return country; } }
        public string City { get { return city; } }
        public string Street { get { return street; } }
        public string House { get { return house; } }
        public string Apartment { get { return apartment; } }

        // Метод для виведення адреси
        public void DisplayAddress()
        {
            Console.WriteLine("Поштова адреса:");
            Console.WriteLine($"Індекс: {Index}");
            Console.WriteLine($"Країна: {Country}");
            Console.WriteLine($"Місто: {City}");
            Console.WriteLine($"Вулиця: {Street}");
            Console.WriteLine($"Будинок: {House}");
            Console.WriteLine($"Квартира: {Apartment}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Введення інформації про адресу
            Console.Write("Введіть індекс: ");
            string index = Console.ReadLine();

            Console.Write("Введіть країну: ");
            string country = Console.ReadLine();

            Console.Write("Введіть місто: ");
            string city = Console.ReadLine();

            Console.Write("Введіть вулицю: ");
            string street = Console.ReadLine();

            Console.Write("Введіть будинок: ");
            string house = Console.ReadLine();

            Console.Write("Введіть квартиру: ");
            string apartment = Console.ReadLine();

            // Створення екземпляра класу Address
            Address address = new Address(index, country, city, street, house, apartment);

            // Виведення інформації про адресу
            address.DisplayAddress();
        }
    }
}
