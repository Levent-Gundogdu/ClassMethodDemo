using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer);
        }

        public void Print(Customer[] customers)
        {

            foreach (var customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.Id + "\nCustomer Name: " + customer.Name + " " + customer.Surname + "\nCustomer birth year: " + customer.BirthYear + "\n -----------------------------------------");
            }

        }

    }
}
