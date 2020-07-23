using System;
using System.Net.Sockets;
using System.Text;

namespace Static
{
    class TienIch
    {
        public static long TinhLuyThua(int CoSo, int SoMu)
        {
                long Ketqua = 1;
                for (int i = 0; i < SoMu; i++)
                {
                Ketqua *= CoSo;
                }
            return Ketqua;
        }
        public static long TinhTong(int CoSo, int SoMu)
        {
            return CoSo + SoMu;
        }
    }
    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            DateTime now = DateTime.Now;
            switch(now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Violet";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Purple";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
            }
        }
        
    }

    // Rút ra: Hàm là 1 class, Phương thức là một con của Hàm. Ví dụ: TienIch là 1 hàm, trong hàm này có 2 phương thứ TinhLuyThua và TinhTong
    class Program
    {
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //int CoSo, SoMu;
            //Console.Write("Mời bạn nhập vào Cơ số: ");
            //CoSo = int.Parse(Console.ReadLine());
            //Console.Write("Mời bạn nhập vào Số mũ: ");
            //SoMu = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kết quả lũy thừa: " + TienIch.TinhLuyThua(CoSo, SoMu));
            //Console.Write("Tổng của hai số là: " + TienIch.TinhTong(CoSo, SoMu));
            //Console.ReadKey();
            Console.WriteLine(" Mau chu dao cua hom nay: " + MauSac.MauChuDao);
            Console.ReadKey();


        }
    }
}
