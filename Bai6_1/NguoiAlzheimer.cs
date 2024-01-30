using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_1
{
    // đối tượng này là class con
    // kế thừa các thuộc tính của class cha : NCT
    // cú pháp :
    // : <tên class cha>
    internal class NguoiAlzheimer : NguoiCaoTuoi
    {
        private string tinhTrang;
        private string donThuoc;

        // constructor ko tham số
        // ctor + tab
        public NguoiAlzheimer()
        {
            
        }

        //constructor có tham số
        // bôi đen toàn bộ thuộc tính private
        // ctrl .
        // generate constructor(.....)
        public NguoiAlzheimer(string ma, string ten, 
                              int tuoi, string tinhTrang, 
                              string donThuoc) : base(ma, ten, tuoi)
        {
            this.tinhTrang = tinhTrang;
            this.donThuoc = donThuoc;
        }

        //các hàm truyền thuộc tính trung gian
        // bôi đen toàn bộ thuộc tính private
        // crtl .
        // chọn encapsulute field (but still use fields)
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string DonThuoc { get => donThuoc; set => donThuoc = value; }


        //ngoài kế thừa thuộc tính
        // cũng có thể kế thừa thông tin từ hàm
        public void InThongTin()
        {
            //in ra các thông tin mà class cha có
            base.InThongTin();
            //in ra thông tin mà chỉ class con có
            Console.WriteLine($"{tinhTrang} | {donThuoc}");
        }
    }
}
