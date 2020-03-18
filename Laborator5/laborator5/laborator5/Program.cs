using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator5
{
    class Program
    {
        static void Main(string[] args)
        {

            testCaz1();
            testCaz2();
            testCaz3();
            testCaz4();
            testCaz5();
            Console.ReadKey();
        }

        public static void testCaz1()
        {
            ServicesCaz1 services = new ServicesCaz1();
            SelfReference sf = new SelfReference();
            sf.Name = "Student";
            services.AddData(sf);
            services.PrintData();
        }

        public static void testCaz2()
        {
            ServicesCaz2 services = new ServicesCaz2();
            services.AddProduct();
            services.PrintPoducts();
        }

        public static void testCaz3()
        {
            ServicesCaz3 services = new ServicesCaz3();
            services.AddPhoto();
            services.PrintPhoto();
        }

        public static void testCaz4()
        {
            ServicesCaz4 services = new ServicesCaz4();
            services.AddBusiness();
            services.PrintBusiness();
        }

        public static void testCaz5()
        {
            ServicesCaz5 services = new ServicesCaz5();
            services.AddEmployee();
            services.PrintEmployee();
            
        }
    }
}
