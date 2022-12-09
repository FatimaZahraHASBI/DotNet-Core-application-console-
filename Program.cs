using FIRSTAPP.Service;
internal class Program
{
    private static void Main(string[] args)
    {
        AccountService accountService = new AccountServiceImpl();
        accountService.AddNewAccount(new Account(1, "USD", 12000));
        accountService.AddNewAccount(new Account(2, "DH", -25000));
        accountService.AddNewAccount(new Account(3, "USD", 43000));
        accountService.AddNewAccount(new Account(4, "EUR", 4400));
        accountService.AddNewAccount(new Account(5, "DH", 1700));
        accountService.AddNewAccount(new Account(6, "USD", 6000));

        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("All accounts :");
        accountService.GetAllAccounts().ForEach(account => Console.WriteLine(account.ToString()));
        Console.WriteLine("--------------------------------------------------------------------------");
        accountService.GetDebitedAccounts().ForEach(account => Console.WriteLine("Debited account : "+account.ToString()));
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Balance AVG = "+accountService.balanceAVG());
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Show account 6 : "+ accountService.GetAccount(6).ToString());
        Console.WriteLine("--------------------------------------------------------------------------");
        accountService.DeleteAccount(6);
        Console.WriteLine("List of accounts after deleting Account 6:");
        accountService.GetAllAccounts().ForEach(account => Console.WriteLine(account.ToString()));
    }
}