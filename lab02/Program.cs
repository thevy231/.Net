
using System;

class Program
{
    static void Main()
    {
        BookList bl = new BookList();
        AccountList al = new AccountList();

        Console.WriteLine("LAB 02 ");
        Console.WriteLine("Add Book:");
        Book b = new Book();
        b.Input();
        bl.Add(b);
        bl.Show();

        Console.WriteLine("Add Account:");
        al.Add();
        al.Report();
    }
}
