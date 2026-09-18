using System;

class Bai1
{
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

        int tong_cac_phan_tu = 0;
        for (int i=0; i<n; i++)
        {
            tong_cac_phan_tu += arr[i];
        }

        Console.Write("Tong cac phan tu trong mang la: " + tong_cac_phan_tu);
    }
}