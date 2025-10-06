public class Program
{
    public static void Main()
    {
        try
        {
            
            Human human = new Human("Giorgi", "Kapanadze", 28, "01012345678", "595123456", "giorgikapanadze@gmail.com");
            human.DisplayInfoInConsole();

            Console.WriteLine("\n--- Banking System ---\n");

           
            Account acc1 = new Account("GE12345678901234567890", "GEL", 2500);
            Account acc2 = new Account("GE98765432109876543210", "GEL", 1200);

            Client client1 = new Client("Nino", "Beridze", "01098765432", acc1);
            Client client2 = new Client("Luka", "Machavariani", "02087654321", acc2);

            Console.WriteLine("-- Client Information --");
            client1.DisplayClient();
            client2.DisplayClient();

            Console.WriteLine("\n-- Transactions --");
            Console.WriteLine("Nino withdraws 500 GEL...");
            client1.Account.Withdraw(500);

            Console.WriteLine("Luka deposits 300 GEL...");
            client2.Account.Deposit(300);

            Console.WriteLine("Nino transfers 200 GEL to Luka...");
            client1.Account.Transfer(client2.Account, 200);

            Console.WriteLine("\n-- Updated Balances --");
            client1.DisplayClient();
            client2.DisplayClient();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
