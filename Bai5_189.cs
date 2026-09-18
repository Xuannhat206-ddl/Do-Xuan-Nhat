using System;
using System.Data.Common;

class Bai5
{
    static string Rever(string s)
    {
        string kq = "";
        for (int i = s.Length - 1; i >= 0; i --)
        {
            kq += s[i];
        } 
        return kq;
    }

    static void Main(string[] args)
    {
        int n;
        Console.Write("Nhap so luong phan tu cho mang: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Nhap lan luot cac phan tu cho mang: ");
        for (int i=0; i<n; i++)
        {
            Console.Write("a[" + i + "] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        string temp = "";
        for (int i=0; i<n; i++)
        {
            temp += arr[i].ToString();
        }

        string _temp = Rever(temp);
        if (temp == _temp)
        {
            Console.WriteLine("Mang da cho doi xung");
        }
        else
        {
            Console.WriteLine("Mang da cho khong doi xung");
        }
    }
}