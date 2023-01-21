using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        ICreditManager financeCreditManager1 = new FinanceCreditManager();
        ICreditManager vehicleCreditManager1 = new VehicleCreditManager();
        ICreditManager mortageCreditManager1 = new MortageCreditManager();

        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService smsLoggerService = new SmsLoggerService();

        List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new SmsLoggerService() };

        ApplicationManager applicationManager1 = new ApplicationManager();
        applicationManager1.Applicate(financeCreditManager1, new List<ILoggerService> {new DataBaseLoggerService(), new SmsLoggerService() });
        //applicationManager1.Applicate(vehicleCreditManager1, smsLoggerService);
        //applicationManager1.Applicate(new TraderCreditManager(), fileLoggerService);
        applicationManager1.Applicate(mortageCreditManager1, loggers);


        List<ICreditManager> creditManager1 = new List<ICreditManager> { financeCreditManager1, vehicleCreditManager1 };
        //applicationManager1.CreditPreliminaryInformation(creditManager1);


    }
}