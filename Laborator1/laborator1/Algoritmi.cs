using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator1
{
    public class Algoritmi
    {

      static public int FindNumberAlg1(int n)
       {
           int result = -1;
           if (n < 1)
               return result;

           for (int i = 1; i < n; i++)
           { int ok = 0;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        ok = 1;
                if (ok==0)
                    result = i;

            }
           return result;
       }
        
       static public int FindNumberAlg2(int n)
        {
            int result = -1;
            if (n <=2)
                return result;
            int ok = 0;

            for (int i = n-1; i >= 1; i--)
            {
                ok = 0;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                    {
                        ok = 1;
                        break;
                    }
                if (ok == 0)
                    return i;

            }
            
                return result;
        }
     }
}
