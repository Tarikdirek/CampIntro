using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TraderCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Trader credit calculated!");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
