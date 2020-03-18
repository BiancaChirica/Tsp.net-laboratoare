using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator5
{
    public class ServicesCaz2
    {
        public void AddProduct()
        {
            using (var context = new Caz2Context())
            {
                var product = new Product
                {
                    SKU = 145536,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product { SKU = 175536,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M, ImageURL = "/pack178.jpg" };
                context.Products.Add(product);
                product = new Product { SKU = 185536,
                    Description = "Range Field Pack",
                    Price = 98.97M, ImageURL = "/noimage.jp" };
                context.Products.Add(product);
                product = new Product { SKU = 205536,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M, ImageURL = "/pack202.jpg" };
                context.Products.Add(product);
                context.SaveChanges();
            }

        }

        public void PrintPoducts()
        {

            using (var context = new Caz2Context())
            {
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);
                }
            }
        }
    }
}
