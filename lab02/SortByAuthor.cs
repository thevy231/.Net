
using System.Collections.Generic;

class SortByAuthor : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Author.CompareTo(y.Author);
    }
}
