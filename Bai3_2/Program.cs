namespace Bai3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region do while
            /* Do while cú pháp: do { enter
             * do
             * {
             *      // thực hiện khối lệnh 
             * }while(<điều kiện trả về true>)
             */

            // Khác nhau giữa while và dowhile
            // 1. vị trí đặt while
            //      while : đặt trên đầu
            //      do while: đặt dưới đít
            // 2. Vận hành
            //      while: check dk trước, lặp sau
            //      dowhile: chạy trước, check sau
            int count = 11;
            while (count < 10) 
            {
                Console.WriteLine("while in ra " + count);
                count++;
            }
            //----------------
            do
            {
                Console.WriteLine("dowhile in ra " + count);
                count++;
            }while (count < 10);
            #endregion

            #region do while + switch case
            int choice; //gán giá trị trong do while là không nhất thiết
            do
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
                switch (choice)
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
            } while (choice != 3);
            #endregion
        }
    }
}