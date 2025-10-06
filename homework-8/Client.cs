public class Client
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PersonalNumber { get; set; }
    public Account Account { get; set; }

    public Client(string firstName, string lastName, string personalNumber, Account account)
    {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("First and last name are required.");
        if (personalNumber.Length != 11)
            throw new ArgumentException("Personal number must be exactly 11 digits.");

        FirstName = firstName;
        LastName = lastName;
        PersonalNumber = personalNumber;
        Account = account;
    }

    public void DisplayClient()
    {
        Console.WriteLine($"{FirstName} {LastName} (PN: {PersonalNumber})");
        Account.DisplayAccount();
    }
}
