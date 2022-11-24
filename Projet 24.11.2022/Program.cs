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

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            
            Console.WriteLine(c.ToString()+"\n");
            
            Console.WriteLine(a.OpenDay());
            Console.WriteLine(b.OpenDay());
            Console.WriteLine(c.OpenDay());
        }

    }
}
