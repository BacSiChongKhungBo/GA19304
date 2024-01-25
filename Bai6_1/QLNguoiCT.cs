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
            lst_nct = new List<NguoiCaoTuoi>();
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
            if (choice == "Y")
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
            nguoiCanXoa = lst_nct.Where(x => x.Ma.Equals(input)).FirstOrDefault();
            if (nguoiCanXoa != null)
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

        #region Sửa
        public void SuaThongTinTheoMa()
        {
            bool timthay = false;
            //B1: nhập mã để kiểm tra
            Console.WriteLine("Xin mời nhập mã cần sửa");
            string input = Console.ReadLine();
            //B2: Chạy foreach tìm người trùng mã và sửa
            foreach (var nguoi in lst_nct)
            {
                if (nguoi.Ma == input)
                {
                    Console.WriteLine("xin mời nhập mã mới");
                    nguoi.Ma = Console.ReadLine();
                    Console.WriteLine("Xin mời nhập tên mới");
                    nguoi.Ten = Console.ReadLine();
                    Console.WriteLine("Xin mời nhập tuổi mới");
                    nguoi.Tuoi = int.Parse(Console.ReadLine());
                    timthay = true;
                    break;
                }
            }
            if (timthay) // tim thấy = true
            {
                Console.WriteLine("Sửa thành công");
            }
            else
            {
                Console.WriteLine("Sửa thất bại");
            }
        }
        #endregion 
        #region Sắp xếp tăng dần
        public void SapXepTangDanBth()
        {
            //B1:tạo 1 danh sách tạm
            List<NguoiCaoTuoi> sorted;
            sorted = lst_nct;
            //B2: sắp xếp
            for (int i = 0; i < sorted.Count; i++)
            {
                for (int j = i + 1; j < sorted.Count; j++)
                {
                    if (sorted[i].Tuoi > sorted[j].Tuoi)
                    {
                        int tmp = sorted[i].Tuoi;
                        sorted[i].Tuoi = sorted[j].Tuoi;
                        sorted[j].Tuoi = tmp;
                    }
                }
            }
            Console.WriteLine("kết quả");
            foreach (var item in lst_nct)
            {
                item.InThongTin();
            }
        }

        public void SapXepDSLinq()
        {
            //B1:tạo 1 danh sách tạm
            List<NguoiCaoTuoi> sorted;
            //B2: sắp xếp = linq
            sorted = lst_nct.OrderBy(nct => nct.Tuoi).ToList();
            //Dịch linq:
            // danh sách người cao tuổi: lst_nct.
            // được sx tăng dần theo tuổi của nct:  OrderBy(nct => nct.Tuoi)
            // và chuyển thành danh sách : ToList()
            //B3:In ra kết quả
            Console.WriteLine("kết quả");
            foreach (var item in lst_nct)
            {
                item.InThongTin();
            }
        }
        #endregion
        #region Sắp xếp giảm dần
        public void SapXepDSLinqDESC()
        {
            List<NguoiCaoTuoi> sorted = lst_nct.OrderByDescending(nct => nct.Tuoi).ToList();
            foreach (var item in lst_nct)
            {
                item.InThongTin();
            }
        }
        #endregion
        #region Tìm kiếm theo mã
        // Chú ý: mã thường là duy nhất nên
        // chỉ cần tạo một đối tượng kết quả
        public void TimTheoMa()
        {
            //B1: chuẩn bị input
            string input;
            Console.WriteLine("Xin mời nhập mã");
            input = Console.ReadLine();
            NguoiCaoTuoi result;
            result = lst_nct.Where(nct => nct.Ma == input).FirstOrDefault();
            // tìm trong danh sách : lst_nct.
            // where(nct => nct.Ma : mà mã người cao tuổi
            // == input : bằng với mã nhập từ bàn phím
            // firstordefault: lấy người đầu tiên hoặc null
            if (result == null)
            {
                Console.WriteLine("Không thấy");
            }
            else
            {
                result.InThongTin();
            }
        }
        #endregion

        #region tìm kiếm theo các thuộc tính bình thường
        // với các thuộc tính bình thường,
        // thay vì tạo đối tượng result
        // thì tạo danh sách đối tượng
        public void TimTheoTuoi()
        {
            //tìm những người có tuổi > 60
            List<NguoiCaoTuoi> results; //danh sách kết quả
            Console.WriteLine("Bạn muốn tìm người > bao nhiêu tuổi");
            int input = int.Parse(Console.ReadLine());
            //linq
            results = lst_nct.Where(nct => nct.Tuoi > input).ToList();
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }

        public void TimTheoKhoangTuoi()
        {
            //tìm những người có tuổi > 60  và < 90
            List<NguoiCaoTuoi> results; //danh sách kết quả
            Console.WriteLine("Bạn muốn tìm người từ bao nhiêu tuổi");
            int inputmin = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn muốn tìm người đén bao nhiêu tuổi");
            int inputmax = int.Parse(Console.ReadLine());
            //linq
            results = lst_nct.Where(nct => nct.Tuoi > inputmin
                                 && nct.Tuoi < inputmax).ToList();
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }

        //Tìm tên bắt đầu bằng ?
        public void TimTheoTen()
        {
            List<NguoiCaoTuoi> results;
            Console.WriteLine("Xin mời nhập họ");
            string input = Console.ReadLine();
            results = lst_nct.Where(nct => nct.Ten.StartsWith(input)).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("không tìm thấy");
                return; // kết thúc hàm mà không chạy bất kì dòng code bên dưới
            }
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }
        public void TimTheoTen1() // tìm tên đệm || tìm theo tên chứa chữ cái
        {
            List<NguoiCaoTuoi> results;
            Console.WriteLine("Xin mời nhập họ");
            string input = Console.ReadLine();
            results = lst_nct.Where(nct => nct.Ten.Contains(input)).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("không tìm thấy");
                return; // kết thúc hàm mà không chạy bất kì dòng code bên dưới
            }
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }

        public void TimTheoTen2() // tìm tên xưng hô || chữ cái cuối cùng của tên
        {
            List<NguoiCaoTuoi> results;
            Console.WriteLine("Xin mời nhập họ");
            string input = Console.ReadLine();
            results = lst_nct.Where(nct => nct.Ten.EndsWith(input)).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("không tìm thấy");
                return; // kết thúc hàm mà không chạy bất kì dòng code bên dưới
            }
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }

        public void TimTheoTen3()
        {
            // không hiển thị họ mà không muốn thấy
            List<NguoiCaoTuoi> results;
            Console.WriteLine("Xin mời nhập họ");
            string input = Console.ReadLine();
            results = lst_nct.Where(nct => !nct.Ten.StartsWith(input)).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("không tìm thấy");
                return; // kết thúc hàm mà không chạy bất kì dòng code bên dưới
            }
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }

        public void TimKetHop()
        {
            // tìm theo ten va tuoi
            List<NguoiCaoTuoi> results;
            Console.WriteLine("Xin mời nhập tên");
            string input = Console.ReadLine();
            Console.WriteLine("Xin mời nhập tuoi");
            int input2 = int.Parse(Console.ReadLine());
            results = lst_nct.Where(nct => nct.Ten.Contains(input) && nct.Tuoi == input2).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("không tìm thấy");
                return; // kết thúc hàm mà không chạy bất kì dòng code bên dưới
            }
            foreach (var nguoi in results)
            {
                nguoi.InThongTin();
            }
        }
        #endregion


    }
}
