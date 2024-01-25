using System.Text;

namespace Bai6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            //QUan trọng
            QLNguoiCT _qlyNCT = new QLNguoiCT();
            int chon;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Nhập 1 hoặc nhiều thức ăn ");
                Console.WriteLine("2. Xuất 1 đối tượng hoặc danh sách đối tượng");
                Console.WriteLine("3. Xuất danh sách người cao tuổi < 70 tuổi");
                Console.WriteLine("4. Tìm người cao tuổi theo mã");
                Console.WriteLine("5. sắp xếp tăng dần theo tuổi");
                Console.WriteLine("5. sắp xếp giảm dần theo tuổi");
                Console.WriteLine("Mời bạn nhap lựa chọn: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        _qlyNCT.ThemNCT();
                        break;
                    case 2:
                        _qlyNCT.XuatDanhSach();
                        break;
                    case 3:

                        break;
                    case 5:
                        _qlyNCT.SapXepDSLinq();
                        break;
                    case 6:
                        _qlyNCT.SapXepDSLinqDESC();
                        break;
                    default:
                        break;

                }
            } while (chon != 4);
        }
    }
}