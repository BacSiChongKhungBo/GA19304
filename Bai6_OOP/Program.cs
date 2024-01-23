using Bai6_OOP.Model;
using System.Text;

namespace Bai6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region nhập xuất tiếng việt trong C#
            //nhập : cho nhập tiếng việt khi sử dụng unikey
            Console.InputEncoding = Encoding.Unicode;
            //xuất : cho phép hiển thị tiếng việt
            Console.OutputEncoding = Encoding.UTF8;
            #endregion
            // quan trong nhất
            // khai báo và khởi tạo đối tượng
            NguoiYeu ny = new NguoiYeu();
            Console.WriteLine("cho anh xin mã em nhé: ");
            ny.MaNY = Console.ReadLine();
            Console.WriteLine("cho anh xin tên em nhé: ");
            ny.Ten = Console.ReadLine();
            Console.WriteLine("Em cao bao nhiêu: ");
            ny.ChieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Em nặng bao nhiêu thế: ");
            ny.CanNang = int.Parse(Console.ReadLine());
            //in thong tin
            ny.InThongTin();

            string ma, ten;
            double cao;
            int nang;
            Console.WriteLine("cho anh xin mã em nhé: ");
            ma = Console.ReadLine();
            Console.WriteLine("cho anh xin tên em nhé: ");
            ten = Console.ReadLine();
            Console.WriteLine("Em cao bao nhiêu: ");
            cao = double.Parse(Console.ReadLine());
            Console.WriteLine("Em nặng bao nhiêu thế: ");
            nang = int.Parse(Console.ReadLine());
            NguoiYeu ny2 = new NguoiYeu(ma, ten, cao, nang);
            ny2.InThongTin();
            Console.WriteLine("Tổng kết thu hoạch");
            Console.WriteLine("danh sách ny hôm nay");
            ny.InThongTin();
            ny2.InThongTin();
        }
    }
}