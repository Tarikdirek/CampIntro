using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class FinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Finance Credit Calculated!");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
