using System;
using System.Data;

class bai6
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi ky tu: ");
        string chuoi_ky_tu = Console.ReadLine();

        Console.Write("Nhap ky tu can dem: ");
        char ky_tu = char.Parse(Console.ReadLine());

        int temp = 0;
        for (int i=0; i<chuoi_ky_tu.Length; i++)
        {
            if (ky_tu == chuoi_ky_tu[i])
            {
                temp++;
            }
        }

        Console.WriteLine("So lan xuat hien ky tu " + ky_tu + " la: " + temp);
    }
}