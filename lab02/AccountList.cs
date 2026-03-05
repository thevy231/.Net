
using System;
using System.Collections;
using System.IO;

class AccountList
{
    ArrayList list = new ArrayList();

    public void Add()
    {
        Account a = new Account();
        a.FillInfo();
        list.Add(a);
    }

    public void Report()
    {
        foreach (Account a in list) a.Show();
    }

    public void SaveFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Account a in list)
                sw.WriteLine($"{a.AccountID}|{a.FirstName}|{a.LastName}|{a.Balance}");
        }
    }

    public void LoadFile(string file)
    {
        list.Clear();
        using (StreamReader sr = new StreamReader(file))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] p = line.Split('|');
                list.Add(new Account
                {
                    AccountID = p[0],
                    FirstName = p[1],
                    LastName = p[2],
                    Balance = double.Parse(p[3])
                });
            }
        }
    }
}
