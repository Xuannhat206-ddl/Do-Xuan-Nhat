using System;

class Bai2
{
    static void Main(string[] args)
    {
        string chuoi_ky_tu = "";
        Console.Write("Nhap chuoi ky tu: ");
        chuoi_ky_tu = Console.ReadLine();

        int so_luong_ky_tu = 0;
        for (int i=0; i<chuoi_ky_tu.Length; i++)
        {
            if (chuoi_ky_tu[i] >= 'a' && chuoi_ky_tu[i] <= 'z'
                || chuoi_ky_tu[i] >= 'A' && chuoi_ky_tu[i] <= 'Z')
            {
                so_luong_ky_tu += 1;
            }
        }

        Console.WriteLine("So luong ky tu trong chuoi: " + so_luong_ky_tu);
    }
}