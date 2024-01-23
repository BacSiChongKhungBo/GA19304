using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_OOP.Model
{
    internal class NguoiYeu
    {
        //B1: liệt kê các thuộc tính
        private string maNY;
        private string ten;
        private double chieuCao;
        private int canNang;

        //B2: ctor + tab
        // tạo 1 đối tượng
        public NguoiYeu()
        {
            
        }

        //B3: tạo 1 đội tuọng với tham số
        /*
         * bôi đen hết thuộc tính ở B1
         * chuột phải chọn quick action and refactoring
         * hoặc crtl + .
         * generate constructor
         */
        public NguoiYeu(string maNY, string ten, double chieuCao, int canNang)
        {
            this.maNY = maNY;
            this.ten = ten;
            this.chieuCao = chieuCao;
            this.canNang = canNang;
        }

        //B4: tạo 1 trung gian cho các thuộc tính
        /*
         * bôi đen hết thuộc tính ở B1
         * chuột phải chọn quick action and refactoring
         * hoặc crtl + .
         * encapsolute fields (still use field)
         */
        public string MaNY { get => maNY; set => maNY = value; }
        public string Ten { get => ten; set => ten = value; }
        public double ChieuCao { get => chieuCao; set => chieuCao = value; }
        public int CanNang { get => canNang; set => canNang = value; }

        public void InThongTin()
        {
            Console.WriteLine($"{maNY} | {ten} | {chieuCao} | {canNang}");
        }
    }
}
