// See https://aka.ms/new-console-template for more information
using System.Transactions;
using System;
using System.IO;

namespace program
{
    
    public class call
    {
        public static void Main() 
        { 
            string saisie;

            Console.WriteLine("enter an option : ");

            saisie = Console.ReadLine();

            switch (saisie)
            {
                case "a":
                    Console.WriteLine("Coucou, je suis A");
                    break;
                case "b":
                    Console.WriteLine("Coucou, je suis A et B");
                    break;
                case "c":
                    Console.WriteLine("Je suis malade avec un certificat`!");
                    break;
                default:
                    Console.WriteLine("This is not an unvaliable option");
                    break;
            }

        }


    }




}
