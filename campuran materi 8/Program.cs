using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campuran_materi_8
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "089 536 725";
            karyawanTetap.Nama = "garox asmoking";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "062 162 847";
            karyawanHarian.Nama = "imam supriyadi";
            karyawanHarian.JumlahJamKerja = 5;
            karyawanHarian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "082 179 111";
            sales.Nama = "gunawan sate";
            sales.JumlahPenjualan = 20;
            sales.Komisi = 50000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
} 