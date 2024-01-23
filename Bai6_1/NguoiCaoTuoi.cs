using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_1
{
    internal class NguoiCaoTuoi
    {
        private string ma;
        private string ten;
        private int tuoi;

        public NguoiCaoTuoi()
        {
            
        }

        public NguoiCaoTuoi(string ma, string ten, int tuoi)
        {
            this.ma = ma;
            this.ten = ten;
            this.tuoi = tuoi;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void InThongTin()
        {
            Console.WriteLine($"{ma} | {ten} | {tuoi}");
        }
    }
}
