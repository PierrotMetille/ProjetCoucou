using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCoucou
{
    public class A
    {
        public override string ToString()
        {
            return "Coucou, je suis A";
        }

        public string OpenDay()
        {
            return "The open day are : " + DateTime.Today.ToString();
        }
    }
}
