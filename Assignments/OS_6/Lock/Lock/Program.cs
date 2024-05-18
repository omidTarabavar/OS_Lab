class Program
{
    private static readonly object _lock = new object();

    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(WithdrawMoney);
            thread.Start(i + 1);
        }

        Console.ReadKey();
    }

    static void WithdrawMoney(object accountId)
    {
        lock (_lock)
        {
            Console.WriteLine($"Account {accountId} is withdrawing money...");
            Thread.Sleep(2000);
            Console.WriteLine($"Account {accountId} has withdrawn money.");
        }
    }
}