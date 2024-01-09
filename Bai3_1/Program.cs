using System.Text;

namespace Bai3_1
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

            #region while
            /*
             * while (<điều kiện trả về true>)
             * {
             *      thực hiện khối lệnh
             *      nếu <điều kiện trả về true>
             *      thỏa mãn
             * }
             * 
             */
            int count = 5;
            while (count <= 10)
            {
                Console.WriteLine("số: " + count);
                count++;
                Console.WriteLine("số sau ++: " + count);
                Console.WriteLine("điều kiện vòng lặp sau");
                Console.WriteLine("sẽ trả về: " + (count <= 10));
            }
            #endregion

            #region while + switch case
            //B1: khai báo khởi tạo giá trị cho biến choice
            int choice = -1; // giá trị không được == giá trị thoát
            //B2: tạo vòng lặp while với 
            // điều kiện != lựa chọn thoát
            while (choice != 3)
            {
                //B3: in ra menu và yêu cầu nhập
                Console.WriteLine("Menu");
                Console.WriteLine("1. Gà rán");
                Console.WriteLine("2. Ghẹ 45kg");
                Console.WriteLine("3. Thoát");
                Console.WriteLine("Xin mời nhập lựa chọn: ");
                //B4: Nhập giá trị cho choice với readline
                choice = int.Parse(Console.ReadLine());
                //B5: viết switch case
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("chọn gà");
                        break;
                    case 2:
                        Console.WriteLine("chọn ghẹ");
                        break;
                    case 3:
                        Console.WriteLine("bye");
                        break;
                    //B6: viết default
                    default:
                        Console.WriteLine("xin mời nhập lại");
                        break;
                }
            }
            #endregion
            //khai báo  4 số ax ay, bx by
            //tạo 1 vòng lặp: (dk thoát là ax = bx, ay != by)
            // nhập giá trị cho ax, ay, bx, by
            // nếu ax = bx, ay != by => in ra màn hình : "bạn đang rơi tự do"
            // ngược lại: xin mời nhập lại tọa độ

            #region portal
            int ax = 0, ay = 0, bx = 0, by = 0;
            while(!(ax == bx && ay != by))
            {
                Console.WriteLine("nhập giá trị ax: ");
                ax = int.Parse(Console.ReadLine());
                Console.WriteLine("nhập giá trị ay: ");
                ay = int.Parse(Console.ReadLine());
                Console.WriteLine("nhập giá trị bx: ");
                bx = int.Parse(Console.ReadLine());
                Console.WriteLine("nhập giá trị by: ");
                by = int.Parse(Console.ReadLine());
                if (ax == bx && ay != by)
                {
                    Console.WriteLine("bạn đang rơi tự do");
                }
                else
                {
                    Console.WriteLine("xin mời nhập lại");
                }
            }
            #endregion
        }
    }
}