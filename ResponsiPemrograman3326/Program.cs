using System;

namespace ResponsiPemrograman3326
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);  

            Console.WriteLine("RESPONSI PEMROGRAMAN");
            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. {0} {1} \t {2}", karyawan1.id, karyawan1.nama, karyawan1.gaji);
            Console.WriteLine("2. {0} {1} \t {2}", karyawan2.id, karyawan2.nama, karyawan2.gaji);

            Console.WriteLine("");

            Karyawan.KenaikanGaji(karyawan1, karyawan2);
            Karyawan.HasilGaji(karyawan1, karyawan2);
        }
    }
}
