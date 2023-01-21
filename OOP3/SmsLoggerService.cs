namespace OOP3
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged on sms!");
        }
    }
}
