using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id+ " " + customer.FirstName + " " + customer.LastName + " " + customer.Age+ " " + customer.City+ " " + customer.Email+ " " + customer.PhoneNumber+ " eklendi!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age + " " + customer.City + " " + customer.Email + " " + customer.PhoneNumber + " güncellendi!");

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age + " " + customer.City + " " + customer.Email + " " + customer.PhoneNumber + " silindi!");
        }
        public void List(Customer[] customers)
        {
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(i+1+". Müşteri: "+customers[i].Id + " " + customers[i].FirstName + " " + customers[i].LastName + " " + customers[i].Age + " " + customers[i].City + " " + customers[i].Email + " " + customers[i].PhoneNumber);

            }
           
        }
    }
}
