
using System;

class Account
{
    public string AccountID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Balance { get; set; }

    public void FillInfo()
    {
        Console.Write("ID: "); AccountID = Console.ReadLine();
        Console.Write("First Name: "); FirstName = Console.ReadLine();
        Console.Write("Last Name: "); LastName = Console.ReadLine();
        Console.Write("Balance: "); Balance = double.Parse(Console.ReadLine());
    }

    public void Show()
    {
        Console.WriteLine($"{AccountID} | {FirstName} {LastName} | {Balance}");
    }
}
