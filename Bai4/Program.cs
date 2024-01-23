namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mảng
            // mảng: tập hợp của các số|ký tự|chuỗi
            // cách khai báo mảng
            int[] arr; // khai báo không giá trị, ko độ dài
            int[] arr1 = { 1, 5, 7, 3, 4, 6 };// có giá trị
            int[] arr2 = new int[4]; //khai báo có độ dài

            double[] arr3 = { 4.3, 4.5, 6.5, 10.0, 12 };
            float[] arr4 = { 3.4f, 3.3f, 6.4f };
            //ký tự và chuỗi
            char[] arr6 = { 'a', 'b', 'c' };
            string[] arr7 = { "hello", "water", "bạch" };

            int[] siSoKhoi10 = { 50, 42, 39, 54, 65 };
            // index:            0 , 1 , 2 , 3 , 4
            //=> độ dài mảng = index cuối + 1
            // giá trị:          50  42  39  54  65
            #endregion
            #region đếm và độ dài
            // .Count() dùng để đếm số lượng phần tử trong mảng
            // số lượng phần tử = độ dài mảng
            // tương tự .Length : trả về độ dài của mảng
            int[] mang1 = { 4, 6, 4, 3, 5, 7, 9, 5, 3, 4, 3, 6, 4, 5, 2, 3, 2, 4, 56, 3, 6, 3, 31, 3, 4, 6, 7, 8, 9, 0, 7, 5, 4, 3, 2, 4, 5, 7, 8, 9, 8, 6, 4, 3, 4, 6, 8, 9, 6, 4, 3 };
            int dodai_mang = mang1.Count();
            int lengthMang1 = mang1.Length;
            Console.WriteLine("do dai mang1 = " + dodai_mang);
            Console.WriteLine("do dai mang1 = " + lengthMang1);
            #endregion
            #region demo mảng
            int sl;
            Console.WriteLine("Sin mời nhập số lượng nhà: ");
            sl = int.Parse(Console.ReadLine());
            int[] dientich = new int[sl];
            // for(int i = 0; i < độ dài mảng; i++)
            int i = 0;
            while (i < dientich.Length)
            {
                Console.WriteLine($"Nhập S nhà thứ {i + 1}: ");
                dientich[i] = int.Parse(Console.ReadLine());
                i++;
            }
            #endregion
            #region Sắp Xếp mảng
            Console.WriteLine("------");
            int[] mang2 = { 1, 5, 4, 2, 9, 3, 5, 7 };
            int[] sortedArray;
            // tăng dần
            sortedArray = mang2.OrderBy(x => x).ToArray();
            // giảm dần
            sortedArray = mang2.OrderByDescending(x => x).ToArray();
            i = 0;
            while (i < sortedArray.Length)
            {
                Console.WriteLine(sortedArray[i]);
                i++;
            }
            #endregion
        }
    }
}