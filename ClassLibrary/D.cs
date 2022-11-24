using ProjetCoucou;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCoucou
{
    public class D : A
    {
        int numvisitor = 15000;
        public string OpenDay()
        {
            return base.OpenDay() + " and we are waiting " + numvisitor + " visitor !";
        }
    }
}
