using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator5
{
    public class ServicesCaz1
    {
        private ModelSelfReferences ctx;
        public ServicesCaz1()
        {
            ctx = new ModelSelfReferences();
        }

        public void AddData(SelfReference selfReference)
        {
            ctx.SelfReferences.Add(selfReference);
            ctx.SaveChanges();
        }

        public List<SelfReference> GetData()
        {
           return ctx.SelfReferences.ToList();
        }
        public void PrintData()
        {
            var items = ctx.SelfReferences;
            foreach (var x in items)
                Console.WriteLine("{0} {1}", x.Name , x.SelfReferenceId);
        }


    }
}
