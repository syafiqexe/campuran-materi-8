using System;
using System.Collections.Generic;
using System.Text;

namespace campuran_materi_8
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}
