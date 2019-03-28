using lab_10_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_110_entity
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {

            // insert new customer

            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer
                {
                    CustomerID = "Seb",
                    ContactName = "Seb Rod",
                    City = "London",
                    Country = "UK",
                    CompanyName = "Sparta"
                };

                // Now add new customer to local database
                db.Customers.Add(customerToCreate);
                // Write changes permanently to real database
                db.SaveChanges();
            }
            Display();


            using (var db = new NorthwindEntities())
            {
                // LINQ query : Microsoft : Language Independent Query
                var customerToUpdate =
                // select all customers in Northwind
                (from customer in db.Customers
                     // choose one where ID matches
                 where customer.CustomerID == "ALFKI"
                 // output the selected one
                 select customer).FirstOrDefault();
                Console.WriteLine("\n\nFinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.City}, {customerToUpdate.Country}");
            }


            using (var db = new NorthwindEntities())
            {
                // LINQ query : Microsoft : Language Independent Query
                var customerToUpdate =
                        db.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
                Console.WriteLine("\n\nFinding one customer again\n");
                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.City}, {customerToUpdate.Country}");

                // UPDATE customer
                customerToUpdate.ContactName = "Fred Flintstone";
                customerToUpdate.City = "Bed Rock";
                // Update DB permanently
                db.SaveChanges();

                Console.WriteLine($"{customerToUpdate.ContactName} lives in {customerToUpdate.City}, {customerToUpdate.Country}");
            }

            //delete

            using (var db = new NorthwindEntities())
            {
                var customerToDelete = db.Customers
                    .Where(c => c.CustomerID == "ADAM9")
                    .FirstOrDefault();
                db.Customers.Remove(customerToDelete);
                db.SaveChanges();
            }

            Display();

        }
        static void Display()
        {
            // encapsulates database connection so it's closed cleanly
            using (var db = new NorthwindEntities())
            {

                customers = db.Customers.ToList<Customer>();
            }


            // use list!!!
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} has ID {customer.CustomerID} and lives in {customer.City}, {customer.Country}.\n");
            }
        }
    }
}