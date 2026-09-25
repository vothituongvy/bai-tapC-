using System;

class Program
{
    static void Main()
    {
        // Bài 2.5.4 — Ma trận hai chiều: tổng đường chéo và kiểm tra đối xứng
        Console.WriteLine("Bài 2.5.4 — Ma trận hai chiều: tổng đường chéo và kiểm tra đối xứng");

        // Dấu , dùng để nói rằng đây là mảng 2 chiều.
        int[,] a =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int n = 3;

        int tongCheoChinh = 0;
        int tongCheoPhu = 0;

        // Tính tổng đường chéo chính và đường chéo phụ
        for (int i = 0; i < n; i++)
        {
            // Đường chéo chính: a[0,0], a[1,1], a[2,2]
            // Đường chéo phụ: a[0,2], a[1,1], a[2,0]
            tongCheoChinh += a[i, i];
            tongCheoPhu += a[i, n - 1 - i];
        }

        Console.WriteLine("Tong duong cheo chinh: " + tongCheoChinh);
        Console.WriteLine("Tong duong cheo phu: " + tongCheoPhu);

        // Kiểm tra ma trận có đối xứng qua đường chéo chính hay không
        bool doiXung = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] != a[j, i])
                {
                    doiXung = false;
                    break;
                }
            }
        }

        if (doiXung)
            Console.WriteLine("Ma tran doi xung qua duong cheo chinh");
        else
            Console.WriteLine("Ma tran khong doi xung qua duong cheo chinh");


        // Bài 2.6.4 — Đếm số lần xuất hiện của chuỗi con (không chồng lấp)
        Console.WriteLine();
        Console.WriteLine("Bài 2.6.4 — Đếm số lần xuất hiện của chuỗi con (không chồng lấp)");

        Console.WriteLine(
            DemXuatHien("abcabcabcabc", "abc")
        );

        Console.WriteLine(
            DemXuatHien("aaaa", "aa")
        );
    }
    
    // Hàm đếm số lần xuất hiện của chuỗi con trong chuỗi lớn (không chồng lấp)
    static int DemXuatHien(string chuoiLon, string chuoiCon)
    {
        int dem = 0;
        int viTri = 0;

        while (true)
        {
            // Tìm chuỗiCon trong chuoiLon, bắt đầu từ vị trí viTri 
            // Nếu tìm thấy thì trả về vị trí tìm được 
            // Nếu không tìm thấy thì trả về -1
            int viTriTimDuoc = chuoiLon.IndexOf(chuoiCon, viTri);
            // Nếu không tìm thấy thì thoát khỏi vòng lặp
            if (viTriTimDuoc == -1)
                break;

            dem++;
            // Cập nhật vị trí tìm kiếm tiếp theo, bắt đầu từ vị trí tìm được + độ dài của chuỗi con
            // Nếu không cập nhật vị trí tìm kiếm tiếp theo thì sẽ bị lặp vô hạn
            // ví dụ: chuoiLon = "aaaa", chuoiCon = "aa"
            // Nếu không cập nhật vị trí tìm kiếm tiếp theo thì sẽ bị lặp vô hạn vì chuoiCon sẽ luôn được tìm thấy ở vị trí 0   
            // Nếu cập nhật vị trí tìm kiếm tiếp theo thì sẽ tìm thấy chuoiCon ở vị trí 2 và thoát khỏi vòng lặp   
            viTri = viTriTimDuoc + chuoiCon.Length;
        }

        return dem;
    }
}

