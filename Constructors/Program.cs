using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName="elyase",LastName="keceli",City="Ordu" };
            Customer customer2 = new Customer(2,"faruk","keceli","ankara");
            Console.WriteLine(customer2.FirstName);
            Customer customer3 = new Customer();
            customer3.Id = 4;
            customer3.FirstName = "Furkan";
            customer3.LastName = "keceli";
            customer3.City = "trabzon";

            //Method(3,"fatih","keceli","samsun");
        }
        //static void Method(int id,string firstName,string lastName,string city)
        //{

        //}
    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
