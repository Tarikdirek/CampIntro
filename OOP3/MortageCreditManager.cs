using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class MortageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortage Credit Calculated!");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
