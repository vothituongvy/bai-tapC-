using System;

class TaiKhoan
{
    private double soDu = 0;

    public void NapTien(double soTien)
    {
        if (soTien > 0)
        {
            soDu += soTien;
        }
        else
        {
            Console.WriteLine("Số tiền không hợp lệ");
        }
    }

    public void RutTien(double soTien)
    {
        if (soTien <= 0)
        {
            Console.WriteLine("Số tiền không hợp lệ");
        }
        else if (soTien > soDu)
        {
            Console.WriteLine("Số dư không đủ");
        }
        else
        {
            soDu -= soTien;
        }
    }

    public void XemSoDu()
    {
        Console.WriteLine("Số dư hiện tại: " + soDu);
    }
}

class Program
{
    static void Main()
    {
        TaiKhoan taiKhoan = new TaiKhoan();

        taiKhoan.NapTien(500000);
        taiKhoan.RutTien(200000);
        taiKhoan.RutTien(1000000);
        taiKhoan.NapTien(-100);
        taiKhoan.XemSoDu();
    }
}