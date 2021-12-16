using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_1
{
    class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = MethodD;
            if (myDelegate1 != null)
            {
                double d = myDelegate1(10);
                Console.WriteLine("{0:.00}",d);
            }
            MyDelegate myDelegate2 = MethodS;
            if (myDelegate2 != null)
            {
                double d = myDelegate2(10);
                Console.WriteLine("{0:.00}", d);
            }
            MyDelegate myDelegate3 = MethodV;
            if (myDelegate3 != null)
            {
                double d = myDelegate3(10);
                Console.WriteLine("{0:.00}", d);
            }
            Console.ReadKey();
        }
        static double MethodD (double r)
        {
            return 2 * Math.PI * r;
        }
        static double MethodS(double r)
        {
            return Math.PI*r*r;
        }
        static double MethodV(double r)
        {
            return 4/3*Math.PI * Math.Pow(r,3);
        }
    }
}
