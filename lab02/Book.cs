
using System;

class Book : IBook, IComparable<Book>
{
    private string title, author, publisher, isbn;
    private int year;
    private string[] chapters = new string[100];
    private int count = 0;

    public string Title { get => title; set => title = value; }
    public string Author { get => author; set => author = value; }
    public string Publisher { get => publisher; set => publisher = value; }
    public int Year { get => year; set => year = value; }
    public string ISBN { get => isbn; set => isbn = value; }

    public string this[int index]
    {
        get => chapters[index];
        set { chapters[index] = value; if (index >= count) count = index + 1; }
    }

    public void Input()
    {
        Console.Write("Title: "); Title = Console.ReadLine();
        Console.Write("Author: "); Author = Console.ReadLine();
        Console.Write("Publisher: "); Publisher = Console.ReadLine();
        Console.Write("Year: "); Year = int.Parse(Console.ReadLine());
        Console.Write("ISBN: "); ISBN = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"{Title} | {Author} | {Publisher} | {Year} | {ISBN}");
    }

    public int CompareTo(Book other)
    {
        return this.Title.CompareTo(other.Title);
    }
}
