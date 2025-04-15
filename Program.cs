using System;
using System.Collections.Generic;

class PhanSo
{
    public int Tu { get; set; }
    public int Mau { get; set; }

    // Constructor
    public PhanSo(int tu = 0, int mau = 1)
    {
        Tu = tu;
        Mau = (mau != 0) ? mau : 1;
    }

    // Nhập phân số từ bàn phím
    public void Nhap()
    {
        Console.Write("Nhập tử số: ");
        Tu = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Nhập mẫu số (khác 0): ");
            Mau = int.Parse(Console.ReadLine());
        } while (Mau == 0);
    }

    // Rút gọn phân số
    public void RutGon()
    {
        int ucln = UCLN(Math.Abs(Tu), Math.Abs(Mau));
        Tu /= ucln;
        Mau /= ucln;

        // Đưa dấu trừ lên tử số nếu cần
        if (Mau < 0)
        {
            Tu = -Tu;
            Mau = -Mau;
        }
    }

    // Cộng 2 phân số
    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tuMoi = a.Tu * b.Mau + b.Tu * a.Mau;
        int mauMoi = a.Mau * b.Mau;
        PhanSo kq = new PhanSo(tuMoi, mauMoi);
        kq.RutGon();
        return kq;
    }

    // Tìm UCLN
    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{Tu}/{Mau}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhanSo> danhSach = new List<PhanSo>();
        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Phân số thứ {i + 1}:");
            PhanSo ps = new PhanSo();
            ps.Nhap();
            danhSach.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSach)
        {
            tong = PhanSo.Cong(tong, ps);
        }

        Console.WriteLine("Tổng các phân số là: " + tong);
    }
}

