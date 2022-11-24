using System.Transactions;
using System;
using System.IO;

namespace ProjetCoucou
{
    
    public class call
    {
        public static void Main() 
        { 
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();
            

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            
            Console.WriteLine(c.ToString()+"\n");
            
            Console.WriteLine(a.OpenDay() + a.separator());
            Console.WriteLine(b.OpenDay() + a.separator());
            Console.WriteLine(c.OpenDay() + a.separator());
            Console.WriteLine(d.OpenDay() + a.separator());


        }

    }
}
