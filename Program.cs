namespace BankEncapsulationNew
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            var balance = bankAccount.GetBalance();

            Console.WriteLine($"Your current balance is {balance}");
            Console.WriteLine($"How much would you like to deposit?");

            double depositAmount; while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0) 
            { Console.Write("Please enter a valid positive amount: "); }

            bankAccount.Deposit(depositAmount); Console.WriteLine($"Your new balance is: {bankAccount.GetBalance()}");

            Console.ReadKey();
        }
    }
}
