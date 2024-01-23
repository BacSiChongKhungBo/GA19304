namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo1 demo1 = new Demo1();
            Console.WriteLine("Hello, World!");
            demo1.InRaManHinh();
            InRaManHinh();
            Demo2 demo2 = new Demo2();
            demo2.InRaManHinh();
        }
        public static void InRaManHinh()
        {
            Console.WriteLine("day la in ra manhinh cua class program");
        }
    }
}