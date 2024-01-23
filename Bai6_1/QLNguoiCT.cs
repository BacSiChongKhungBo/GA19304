using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_1
{
    internal class QLNguoiCT
    {
        //B1:
        //- Khai báo đối tượng
        private NguoiCaoTuoi nct;
        //- Khai báo danh sách đối tượng
        //List<đối tương> tên;
        private List<NguoiCaoTuoi> lst_nct;

        //B2: ctor + tab
        // và khởi tạo danh sách đã khai báo
        public QLNguoiCT()
        {
            lst_nct = new List<NguoiCaoTuoi> ();
        }

        #region Thêm đối tượng
        public void ThemNCT()
        {
            //nhập được đối tượng
            //hỏi có muốn nhập tiếp hay không
            //B1: khai báo, khởi tạo biến hợp lý
            nct = new NguoiCaoTuoi();
            string choice = "N";
            //B2: Nhập thông tin từ màn hình
            Console.Write("Xin mời nhập mã: ");
            nct.Ma = Console.ReadLine();
            Console.Write("Xin mời nhập tên: ");
            nct.Ten = Console.ReadLine();
            Console.Write("Xin mời nhập tuổi: ");
            nct.Tuoi = int.Parse(Console.ReadLine());
            //B3: tiến hành thêm vào danh sách
            lst_nct.Add(nct);
            Console.WriteLine("Thêm thành công");
            //------------------------------------
            //B4: hỏi muốn nhập tiếp hay ko
            Console.WriteLine("bạn có muốn nhập tiếp ko?");
            Console.WriteLine("Y/N?");
            choice = Console.ReadLine();
            if(choice == "Y") 
            {
                ThemNCT();
            }
            
        }
        #endregion

        #region Xuất
        public void XuatDanhSach()
        {
            //B1: sử dụng foreach
            foreach (var nguoi in lst_nct)
            {
                //B2: SD hàm in thông tin
                nguoi.InThongTin();
            }
        }
        #endregion
        #region XÓA
        public void xoaNCT()
        {
            //tìm mã để có cơ sở xóa
            //B1: nhập mã
            string input;
            Console.WriteLine("Xin mời nhập mã cần xóa:");
            input = Console.ReadLine();
            //B2: tìm mã
            //C1: Linq
            NguoiCaoTuoi nguoiCanXoa;
            nguoiCanXoa  = lst_nct.Where(x => x.Ma.Equals(input)).FirstOrDefault();
            if(nguoiCanXoa != null)
            {
                lst_nct.Remove(nguoiCanXoa);
            }
            else
            {
                Console.WriteLine("không tìm thấy");
            }
            //C2:trẩu
            //bool isExist = false;
            //string input2;
            //NguoiCaoTuoi nguoiCanXoa2 = new NguoiCaoTuoi();
            //Console.WriteLine("Xin mời nhập mã cần xóa:");
            //input2 = Console.ReadLine();
            //foreach(var nguoi in lst_nct)
            //{
            //    if(input2 == nguoi.Ma)
            //    {
            //        isExist = true;
            //        nguoiCanXoa2 = nguoi;
            //        break;
            //    }
            //}
            //if (isExist) //isExist == true
            //{
            //    lst_nct.Remove(nguoiCanXoa2);
            //    Console.WriteLine("Xóa thành công");
            //}
            //else
            //{
            //    Console.WriteLine("Không tìm thấy");
            //}
        }
        #endregion

    }
}
