namespace   FIRSTAPP.Service
{
    class AccountServiceImpl : AccountService
    {
        private Dictionary<int, Account> accounts = new Dictionary<int, Account>();
        public Account AddNewAccount(Account account1)
        {
            this.accounts.Add(account1.id, account1);
            return account1;
        }
        public void DeleteAccount(int id){accounts.Remove(id);}
        public List<Account> GetAllAccounts(){return accounts.Values.ToList();}
        public Account GetAccount(int id){return this.accounts[id];}
        public Account UpdateAccount(Account account1)
        {
            Account account = GetAccount(account1.id);
            account.balance = account1.balance;
            account.currency = account1.currency;
            return account;
        }
        public List<Account> GetDebitedAccounts()
        {
            return this.accounts.Values.Where(account => account.balance < 0).ToList();
        }
        public double balanceAVG()
        {
            return accounts.Values.Average(acc => acc.balance);
        }
    }
}