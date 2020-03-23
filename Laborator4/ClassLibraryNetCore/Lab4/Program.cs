using System;
using ClassLibraryNetCore;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            TestPerson();
           // TestClientOrder();


       
        }

        static void TestPerson()
        {
            using (PersonContext pctx = new PersonContext())
            {
                PersonModel p1 = new PersonModel("Bianca", "M", "Chirica", "1234567890");
                pctx.Persons.Add(p1);
                pctx.SaveChanges();
            }
        }

        static void TestClientOrder()
        {
            using (ClientOrderContext context = new ClientOrderContext())
            {

                ClientModel c = new ClientModel()
                {
                    Name = "Customer 1",
                    Email = "Email"
                };

                OrderModel o1 = new OrderModel()
                {
                    Value = 200,
                    Client = c
                };
                OrderModel o2 = new OrderModel()
                {
                    Value = 300,
                    Client = c
                };
                c.Orders.Add(o1);
                c.Orders.Add(o2);

                context.Clients.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Clients;
                foreach (var x in items)
                {
                    Console.WriteLine("Client : {0}, {1}, {2}",
                   x.ClientId, x.Name, x.Email);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}",
                       ox.OrderId, ox.Value.ToString());
                }
            }
        }
    }
}
