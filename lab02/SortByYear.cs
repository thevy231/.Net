
using System.Collections.Generic;

class SortByYear : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        return x.Year.CompareTo(y.Year);
    }
}
