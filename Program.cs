using System;
using System.Collections.Generic;

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double r)
    {
        BanKinh = r;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double c)
    {
        Canh = c;
    }

    public override double TinhChuVi()
    {
        return 4 * Canh;
    }

    public override double TinhDienTich()
    {
        return Canh * Canh;
    }
}

class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double TinhChuVi()
    {
        return 2 * (Dai + Rong);
    }

    public override double TinhDienTich()
    {
        return Dai * Rong;
    }
}

class HinhTamGiac : Hinh
{
    public double a, b, c;

    public HinhTamGiac(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double TinhChuVi()
    {
        return a + b + c;
    }

    public override double TinhDienTich()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Công thức Heron
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Hinh> danhSachHinh = new List<Hinh>();

        // Thêm các hình mẫu
        danhSachHinh.Add(new HinhTron(5));
        danhSachHinh.Add(new HinhVuong(4));
        danhSachHinh.Add(new HinhChuNhat(3, 6));
        danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

        double tongChuVi = 0, tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            double cv = hinh.TinhChuVi();
            double dt = hinh.TinhDienTich();

            tongChuVi += cv;
            tongDienTich += dt;

            Console.WriteLine($"Chu vi: {cv:F2}, Diện tích: {dt:F2}");
        }

        Console.WriteLine($"\nTổng chu vi các hình: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
    }
}
using System;
using System.Collections.Generic;

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double r)
    {
        BanKinh = r;
    }

    public override double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public override double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double c)
    {
        Canh = c;
    }

    public override double TinhChuVi()
    {
        return 4 * Canh;
    }

    public override double TinhDienTich()
    {
        return Canh * Canh;
    }
}

class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double TinhChuVi()
    {
        return 2 * (Dai + Rong);
    }

    public override double TinhDienTich()
    {
        return Dai * Rong;
    }
}

class HinhTamGiac : Hinh
{
    public double a, b, c;

    public HinhTamGiac(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double TinhChuVi()
    {
        return a + b + c;
    }

    public override double TinhDienTich()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Công thức Heron
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Hinh> danhSachHinh = new List<Hinh>();

        // Thêm các hình mẫu
        danhSachHinh.Add(new HinhTron(5));
        danhSachHinh.Add(new HinhVuong(4));
        danhSachHinh.Add(new HinhChuNhat(3, 6));
        danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

        double tongChuVi = 0, tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            double cv = hinh.TinhChuVi();
            double dt = hinh.TinhDienTich();

            tongChuVi += cv;
            tongDienTich += dt;

            Console.WriteLine($"Chu vi: {cv:F2}, Diện tích: {dt:F2}");
        }

        Console.WriteLine($"\nTổng chu vi các hình: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
    }
}
