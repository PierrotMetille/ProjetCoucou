// See https://aka.ms/new-console-template for more information
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

            Console.WriteLine(a.toString());
            Console.WriteLine(b.toString());
            Console.WriteLine(c.toString());
        }


    }




}
