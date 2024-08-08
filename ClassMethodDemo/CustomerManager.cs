using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void CustomerInfo(Customer[] customerInformation)
        {

            foreach (var info in customerInformation)
            {
                Console.WriteLine("Customer Name: " + info.CustomerName);
                Console.WriteLine("Customer Surname: " + info.CustomerSurname);
                Console.WriteLine("Customer Birth Year: " + info.CustomerBirthYear);
                Console.WriteLine("Customer Income: " + info.CustomerIncome);
                Console.WriteLine(" ----------------------- ");

            }
        }

        public void ListCustomers(Customer[] customers)
        {
            foreach (Customer _customer in customers)
            {
                Console.WriteLine("Customer Full Name: " + _customer.CustomerName + " " + _customer.CustomerSurname);
            }
        }

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " added to the customer list.");
        }

        public void DeleteCustomers(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " deleted from the customer list.");
        }
    }
}
