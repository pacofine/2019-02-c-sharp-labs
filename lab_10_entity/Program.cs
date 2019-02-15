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
            // inserting new customer
            using (var db = new NorthwindEntities())
            {
                var customerToCreate = new Customer
                {
                    CustomerID = "JAMES",
                    ContactName = "James Daniel",
                    City = "Richmond",
                    CompanyName = "Sparta Global"
                };

                // add new customer to local database
                db.Customers.Add(customerToCreate);

                //write changes permenantly to database
                db.SaveChanges();
            }

            //CRUD C:create, R:read, U:update, D:delete

            // select one customer
            using (var db = new NorthwindEntities())
            {
                // LINQ query  :  Microsoft  :  Language Independent Query
                var customerToUpdate =
                    // select all customer in Northwind
                    (from customer in db.Customers
                         // choose one where ID matches
                     where customer.CustomerID == "JAMES"
                     // output this one selected
                     select customer).FirstOrDefault(); //FirstOrDefault was used becuase C# doesn't know that only one 
                                                        //customer can be returned so it makes customerToUpdate 
                                                        //an array. FOD returns the first hit.

                Console.WriteLine("\nFinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName} has ID " + $"{customerToUpdate.CustomerID} from {customerToUpdate.City}");
            }

            //select one customer cleaner code (Pt.2)
            using (var db = new NorthwindEntities())
            {
                var customerToUpdate =
                    db.Customers.Where(c => c.CustomerID == "JAME1").FirstOrDefault();
                Console.WriteLine("\nFinding one customer\n");
                Console.WriteLine($"{customerToUpdate.ContactName} has ID " + $"{customerToUpdate.CustomerID} from {customerToUpdate.City}");

                //Update customer
                customerToUpdate.ContactName = "Katie James";

                //Update database permanently
                db.SaveChanges();
            }

            displayAll();

            //delete customer
            using (var db = new NorthwindEntities())
            {
                var customerToDelete =
                    db.Customers.Where(c => c.CustomerID == "JAME1").FirstOrDefault();

                //delete customer
                db.Customers.Remove(customerToDelete);

                //update changes permenatly on database
                db.SaveChanges();

            }

            displayAll();
        }

        static void displayAll()
        {
            //encapsulates database connection so its closed cleanly
            using (var db = new NorthwindEntities())
            {
                //customers list = (read from northwind )
                //                  (pull out all customers)
                //                  send to list of customers)
                customers = db.Customers.ToList<Customer>();
            }

            //use list!!!
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} has ID " + $"{customer.CustomerID} from {customer.City}");
            }
        }
    }
}