// Bài 2.1.4 — Tam giác số có giới hạn tổng mỗi dòng
using System;

class Program
{
    static void Main()
    {
        int tongTatCa = 0;

        for (int i = 1; i <= 5; i++)
        {
            int tongDong = 0;

            for (int j = 1; j <= i; j++)
            {
                if (tongDong + j > 7)
                {
                    break;
                }

                Console.Write(j + " ");
                tongDong += j;
            }

            Console.WriteLine("Tổng dòng: " + tongDong);
            tongTatCa += tongDong;
        }

        Console.WriteLine("Tổng tất cả các dòng: " + tongTatCa);
    }
}
// Bài 2.3.3 — Kết hợp hàm tính lũy thừa và hàm kiểm tra số nguyên tố

class Program
{
    static int LuyThua(int x, int y)
    {
        int ketQua = 1;

        for (int i = 1; i <= y; i++)
        {
            ketQua *= x;
        }

        return ketQua;
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        for (int i = 2; i <= 20; i++)
        {
            if (LaSoNguyenTo(i))
            {
                int binhPhuong = LuyThua(i, 2);

                Console.WriteLine(i + " - Bình phương: " + binhPhuong);
            }
        }
    }
}