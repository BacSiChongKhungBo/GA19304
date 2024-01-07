namespace Bai2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch case
            int choice;

            Console.WriteLine("menu");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Continue");
            Console.WriteLine("3. Load game");
            Console.WriteLine("4. Setting");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Xin mời nhập lựa chọn");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Bạn chọn new game");
                    break;
                case 2:
                    Console.WriteLine("Bạn chọn chơi tiếp");
                    break;
                case 3:
                    Console.WriteLine("Bạn chọn load game");
                    break;
                case 4:
                    Console.WriteLine("Bạn chọn setting");
                    break;
                case 5:
                    Console.WriteLine("Bạn chọn thoát game");
                    break;
                default:
                    // vì ko chọn vào các mục thì ko làm gì
                    break;
            }
            #endregion
        }
    }
}