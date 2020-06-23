using System;
using System.Collections.Generic;
using System.Text;

namespace campuran_materi_8
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
