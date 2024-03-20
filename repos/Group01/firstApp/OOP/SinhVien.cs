using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp.OOP
{
    public class SinhVien
    {


        public string MaSV { get; set; }
        public string hoten { get; set; }
        public EGENDER GENDER {  get; set; }

        public DateTime DOB { get; set; }
        public static List<SinhVien> GETSV ()
        { 
            var ds =new List<SinhVien>();
            ds.Add(new SinhVien { DOB = new DateTime(2002, 8, 10), MaSV = "1", hoten = "Long", GENDER = EGENDER.Male });
            ds.Add(new SinhVien { DOB = new DateTime(2002, 8, 10), MaSV = "2", hoten = "Hoang", GENDER = EGENDER.Male });
            ds.Add(new SinhVien { DOB = new DateTime(2002, 8, 12), MaSV = "3", hoten = "Ly", GENDER = EGENDER.Male });
            ds.Add(new SinhVien { DOB = new DateTime(2002, 8, 30), MaSV = "4", hoten = "Dung", GENDER = EGENDER.Male });
            ds.Add(new SinhVien { DOB = new DateTime(2002, 10, 16), MaSV = "5", hoten = "Nam", GENDER = EGENDER.Othres });
            ds.Add(new SinhVien { DOB = new DateTime(2002, 9, 20), MaSV = "6", hoten = "Hong", GENDER = EGENDER.Female });
            return ds;
        }

        public override string ToString()
        {
            return $"hoten: {hoten}, Gender: {GENDER}, DOB: {DOB:yyyy/MM/d}";
        }
        public enum EGENDER
        {
            Male,Female,Othres
        }

    }
}
