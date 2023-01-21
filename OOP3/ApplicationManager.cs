using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{

    // Method injection
    internal class ApplicationManager
    {
        public void Applicate(ICreditManager creditManager, List<ILoggerService> loggerServices) 
        {
            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPreliminaryInformation(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
           
        }

    }
}
