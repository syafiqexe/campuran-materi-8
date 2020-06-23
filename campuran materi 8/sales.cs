using System;
using System.Collections.Generic;
using System.Text;

namespace campuran_materi_8
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
