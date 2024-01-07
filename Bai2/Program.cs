using System.Text;

namespace Bai2
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

            #region if
            /*
             * điều kiện:
             * 1. so sánh: < > <= >= == !=
             * 2.true false
             */

            /*
             * if (<điều kiện>)
             * {
             *      thực thi câu lệnh ở trong if
             *      nếu điều kiện trả về true
             * }
             */
            int diem = 6;
            if(diem < 6) // 6 < 6 => false
            {
                Console.WriteLine("nôn 6 lít cho DVSV");
            }
            if (diem >= 6)
            {
                Console.WriteLine("đóng 1 củ 2 môn tiếp");
            }
            #endregion

            #region if else
            /*
             * if (<điều kiện>)
             * {
             *      thực thi câu lệnh ở trong if
             *      nếu điều kiện trả về true
             * }
             * else 
             * {
             *      chỉ hoạt động khi
             *      điều kiện if ko thỏa mãn
             * }
             */
            float soDuTK = 60000;
            float soTienRut;
            Console.WriteLine("Xin mời nhập số tiền cần rút");
            soTienRut = float.Parse(Console.ReadLine());
            if (soTienRut <= soDuTK)
            {
                Console.WriteLine("rút thành công");
                Console.WriteLine("Số dư còn lại:" + (soDuTK - soTienRut));
            }
            else
            {
                Console.WriteLine("Rút thất bại, bạn ko đủ số dư");
            }
            #endregion

            #region if else if
            /*
             * if (<điều kiện 1>)
             * {
             *      thực thi câu lệnh ở trong if
             *      nếu điều kiện 1 trả về true
             * }
             * else if (<điều kiện 2>)
             * {
             *      thực thi câu lệnh ở trong if
             *      nếu điều kiện 2 trả về true
             * }
             * if (<điều kiện n>)
             * {
             *      thực thi câu lệnh ở trong if
             *      nếu điều kiện n trả về true
             * }
             * else 
             * {
             *      chỉ hoạt động khi
             *      điều kiện if và tất cả các else if ko thỏa mãn
             * }
             */
            #endregion
            int diemTK; // mốc điêm 5 8 9 10
            Console.WriteLine("Xin mời nhập điêm: ");
            diemTK = int.Parse(Console.ReadLine());
            if (diemTK < 5)
            {
                Console.WriteLine("Học sinh Yếu");
            }
            else if (diemTK >= 5 && diemTK < 8)
            {
                Console.WriteLine("Tiến tiến");
            }
            else if (diemTK >= 8 && diemTK < 9)
            {
                Console.WriteLine("Giỏi");
            }
            else
            {
                Console.WriteLine("Xuất sắc");
            }

            #region lưu ý dùng điều kiện if else
            /*
             * 1. luôn luôn bắt đầu bằng if
             * 2. Không bao giờ được kết thúc = else if
             * 3. không lồng quá 3 if
             */
            #endregion

            #region demo phai phai
            /*
             * các bộ phận ở trên kẻ địch sẽ được chia ra 
             * thành các vùng nhận sát thương tương ứng:
             * 1. đầu : 130 hp
             * 2. ngực : 49 hp
             * 3. tay : 34 hp
             * 4. chân : 25hp
             * Hp của địch là 100
             * Xác định bắn vào đâu
             * phát bắn khiến địch còn bnh máu
             * kẻ địch chết hay không
             * 
             */
            int dau = 1;
            int nguc = 2;
            int tay = 3;
            int hp_enemy = 100;
            int target_rig;
            Console.WriteLine("Ngắm vào đâu của địch: ");
            target_rig = int.Parse(Console.ReadLine());
            if (target_rig == dau)
            {
                hp_enemy = hp_enemy - 130;
            }
            else if(target_rig == nguc)
            {
                hp_enemy = hp_enemy - 49;
            }
            else if (target_rig == tay)
            {
                hp_enemy = hp_enemy - 34;
            }
            else
            {
                hp_enemy = hp_enemy - 25;
            }
            if (hp_enemy <= 0) 
            {
                Console.WriteLine("kẻ địch chết với máu còn lại: " + hp_enemy);
            }
            else
            {
                Console.WriteLine("Kẻ địch sống với máu còn lại: " + hp_enemy);
            }
            #endregion
        }
    }
}