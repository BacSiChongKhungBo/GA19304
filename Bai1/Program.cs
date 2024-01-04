using System.Text;

namespace Bai1
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
            #region những thứ cơ bản khi dùng VS
            //: // là comment
            /*
             * comment đến chết
             * thích thêm dòng nữa
             * 1 dòng nữa
             */
            // cw + tab: Console.Writeline()
            Console.WriteLine("Bét ys việt nam, múa múa ha sa ghi một vẩy 5 em");
            // Ctrl + K + D: làm đẹp
            // Ctrl + S: save code
            // Ctrl + O: open
            // Ctrl + shift + N: Tạo project mới tron sln
            #endregion
            #region biến và kiểu dữ liệu
            int tuoi; //tuổi, số giờ, tiền mặt,... số nguyên
            float diemTB; // số thực : điểm chác, số liệu, tính toán
            double soDuTK;// y hệt float nhưng to hơn
            string ten;// tên, địa chỉ, chức danh, tiêu đề
            bool sex;// giới tính, đúng sai, flag

            //------------------------
            // biến khác
            char kyTu;
            DateTime tgian;
            decimal soCucLon;
            #endregion
            #region xuất yêu cầu và nhập dữ liệu
            Console.WriteLine("Xin mời nhập tên: ");
            ten = Console.ReadLine();
            Console.WriteLine("Xin mời nhập tuổi: ");
            // Parse: chuyển sang dữ liệu mình muốn
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập điểm TB: ");
            diemTB = float.Parse(Console.ReadLine());
            #endregion
            #region xuất dữ liệu kèm biến
            Console.WriteLine("Tên: " + ten);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Điểm TB: " + diemTB);
            // in nhiều biến 1 lúc
            // C1: nên dùng khi < 2 biến (cộng chuỗi)
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi);
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi + "Điểm TB: " + diemTB);
            // C2: dùng khi quá nhiều biến cần hiển thị
            Console.WriteLine($"Tên: {ten} Tuổi: {tuoi} Điểm TB: {diemTB}");
            #endregion
        }
    }
}