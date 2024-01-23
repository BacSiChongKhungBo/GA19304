namespace Bai4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for
            // điểm từ 0 -> 10 là hợp lệ
            int diem = 0;
            // bắt đầu với i = 0;
            // lặp lại chừng nào i < <giá trị>
            // với mỗi lần lặp, i + thêm ? 
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"điểm {i} là điểm hợp lệ");
            }
            #endregion
        }
    }
}