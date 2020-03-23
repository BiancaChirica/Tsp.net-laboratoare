using System;
using System.Text.RegularExpressions;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            // TestPerson();

            //TesTOneToMany();

            TestPManyToMany();

            Console.ReadKey();
        }
        static void TestPerson()
        {
            Console.WriteLine("Add a person in db");
            Regex regex = new Regex("^[A-Za-z-]+$");
            Regex regexPhone = new Regex("^[0-9]{10}$");

            string firstName = "";
            string lastName = "";
            string middleName = "";
            string phone = "";



            while (!regex.IsMatch( firstName))
            {
                Console.WriteLine("Enter First name: (doar litere)");
                firstName = Console.ReadLine();
            }

            while (!regex.IsMatch(lastName))
            {
                Console.WriteLine("Enter Last name: (doar litere)");
                 lastName = Console.ReadLine();
            }

            while (!regex.IsMatch(middleName))
            {
                Console.WriteLine("Enter Middle name: (doar litere)");
                 middleName = Console.ReadLine();
            }

            while (!regexPhone.IsMatch(phone))
            {
                Console.WriteLine("Enter telephone number: (10 cifre)");
              phone = Console.ReadLine();
            }


            using (Model1Container1 context = new Model1Container1())
            {
                Person p = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MidleName = middleName,
                    TelephonNumber = phone,
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.PersonId, x.FirstName);
            }
        }

        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");

            Console.WriteLine("Add a customer in db");
            Regex regex = new Regex("^[A-Za-z-]+$");
            Regex regexCifre = new Regex("^[0-9-]+$");

            string name = "";
            string city = "";
            string value = "";
            string date = "";

            while (!regex.IsMatch(name))
            {
                Console.WriteLine("Enter customer name: (doar litere)");
                name = Console.ReadLine();
            }

            while (!regex.IsMatch(city))
            {
                Console.WriteLine("Enter customer city: (doar litere)");
                city = Console.ReadLine();
            }


            using (CustomerOrderContainer context =
           new CustomerOrderContainer())
            {
                Customer c = new Customer()
                {
                    Name = name,
                    City = city,
                };

                context.Customers.Add(c);


                while (value != "exit" || date != "exit")
                {
                    value = "";
                    date = "";

                    Console.WriteLine("To exit write : 'exit'");
                    while (!regexCifre.IsMatch(value))
                    {
                        Console.WriteLine("Enter order value : (cifre)");
                        value = Console.ReadLine();
                    }

                    Decimal val = 0;
                    try
                    {
                        val = Decimal.Parse(value);
                    } catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    while (!regexCifre.IsMatch(date))
                    {
                        Console.WriteLine("Enter order date : (DateTime yyyy-mm-dd)");
                        date = Console.ReadLine();
                    }


                    DateTime dat = DateTime.Now;
                    try
                    {
                        dat = DateTime.Parse(date);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    Order o1 = new Order()
                    {
                        TotalValue = val,
                        Date = dat,
                        Customer = c
                    };

                    context.Orders.Add(o1);
                }

                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }


        static void TestPManyToMany()
        {
            using (ModelManyToManyContainer context = new ModelManyToManyContainer())
            {
                Artist artist = new Artist()
                {
                    FirstName = "Artist FirstName ",
                    LastName = "Artist LastName "
                };

                Artist artist2 = new Artist()
                {
                    FirstName = "Artist 2 FirstName ",
                    LastName = "Artist 2 LastName "
                };

                Album album = new Album()
                {
                    AlbumName = "Album "
                };

                artist.Albums.Add(album);
                artist2.Albums.Add(album);

                album.Artists.Add(artist);
                album.Artists.Add(artist2);

                context.Artists.Add(artist);
                context.Artists.Add(artist2);
                context.Albums.Add(album);
                context.SaveChanges();

            }

            Console.WriteLine("Verificati baza de date pentru confirmarea testarii many to many");
        }


    }

}
