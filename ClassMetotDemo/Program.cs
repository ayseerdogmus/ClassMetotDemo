using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[] {
                new Customer{
                Id = 1,
                FirstName = "Ayşe",
                LastName = "Ayse",
                Age = 1,
                City = "Kayseri",
                Email = "ayse@ayse.com",
                PhoneNumber = "111111111" },
                new Customer{
                 Id = 2,
                FirstName = "Beyza",
                LastName = "Beyza",
                Age = 4,
                City = "İstanbul",
                Email = "beyza@beyza.com",
                PhoneNumber = "222222222" },
                new Customer{
                Id = 3,
                FirstName = "Fatma",
                LastName = "Fatma",
                Age = 2,
                City = "İstanbul",
                Email = "fatma@fatma.com",
                PhoneNumber = "333333333" }
            };

            CustomerManager customerManager =new CustomerManager();
            customerManager.Add(customers[0]);
            customerManager.Update(new Customer
            {
                Id = 3,
                FirstName = "Asuman",
                LastName = "Asuman",
                Age = 8,
                City = "İzmir",
                Email = "asuman@asuman.com",
                PhoneNumber = "4444444444"
            });
            customerManager.Delete(customers[2]);
            customerManager.List(customers);
        }
    }
}
