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
            Console.WriteLine(customer.FirstName+" adlı müşteri eklendi!");
            Console.WriteLine("----------------------");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" adlı müşterinin bilgileri");
            Console.WriteLine("Müşteri Id:{0}",customer.CustomerId);
            Console.WriteLine("Müşteri Adı:{0}",customer.FirstName);
            Console.WriteLine("Müşteri Soyadı:{0}",customer.LastName);
            Console.WriteLine("Müşteri Adresi:{0}",customer.Address);
            Console.WriteLine("Müşteri Tc:{0}",customer.TcNo);
            Console.WriteLine("----------------------");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" adlı müşteri veritabanından silindi.");
            Console.WriteLine("----------------------");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" adlı müşterinin verileri güncellendi.");
        }
    }
}
