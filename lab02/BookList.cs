
using System.Collections.Generic;

class BookList
{
    private List<Book> list = new List<Book>();

    public void Add(Book b) => list.Add(b);

    public void Show() { foreach (var b in list) b.Show(); }

    public void Sort(IComparer<Book> cmp) => list.Sort(cmp);
}
