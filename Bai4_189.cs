using System;

class Bai4
{
    static void Main(string[] args)
    {
        string chuoi_ky_tu = "";
        Console.Write("Nhap chuoi ky tu: ");
        chuoi_ky_tu = Console.ReadLine();

        string _chuoi_ky_tu = "";

        for (int i = chuoi_ky_tu.Length - 1; i >= 0; i --)
        {
            _chuoi_ky_tu += chuoi_ky_tu[i];
        } 

        Console.WriteLine("Chuoi dao nguoc la: " + _chuoi_ky_tu); 
    }
}