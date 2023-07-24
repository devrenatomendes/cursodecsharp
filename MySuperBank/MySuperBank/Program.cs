namespace MySuperBank
{
        class Program
    {
            static void Main(string[] args)
            {
            var account = new BankAccount ("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Cap");
                Console.WriteLine($"Your new balance is ${account.Balance}");


            account.MakeWithdrawal(300, DateTime.Now, "Jantar");
                Console.WriteLine($"Your new balance is ${account.Balance}");

            Console.WriteLine(account.GetAccountHistory());

            
        }

    }
}


