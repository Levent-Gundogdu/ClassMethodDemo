using System.ComponentModel;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
          Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Alex";
            customer1.Surname = "Walter";
            customer1.BirthYear = "1993";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Carl";
            customer2.Surname = "Carlson";
            customer2.BirthYear = "2000";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Max";
            customer3.Surname = "Donville";
            customer3.BirthYear = "1998";

            Customer[] customers = { customer1, customer2, customer3};

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);


            customerManager.Delete(customer2);

            customerManager.Print(customers);


        }
    }
}