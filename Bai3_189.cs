using System;

class Bai3
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

        int phan_tu_lon_nhat = arr[0];
        for (int i=1; i<n; i++)
        {
            if (phan_tu_lon_nhat < arr[i])
            {
                phan_tu_lon_nhat = arr[i];
            }
        }

        Console.WriteLine("Phan tu lon nhat trong mang la: " + phan_tu_lon_nhat);

    }
}