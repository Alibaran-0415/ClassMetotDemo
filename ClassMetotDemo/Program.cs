using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirstName = "Muhammet";
            customer1.LastName = "BARAN";
            customer1.Address = "Kahraman Sokak No:32 Daire:7";
            customer1.TcNo = "23423423524";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.List(customer1);
            customerManager.Delete(customer1);
            customerManager.Update(customer1);

            Console.ReadLine();
        }
    }
}
