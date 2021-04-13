using System;
namespace ResponsiPemrograman3326
{
    public class Karyawan
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int gaji { get; set; }
        public Karyawan(int Nik, string Nama, int GajiBulanan)
        {
            if (gaji < 0)
            {
                this.gaji = 0;
            }
            else
            {
                this.gaji = GajiBulanan;
            }

            this.id = Nik;
            this.nama = Nama;
        }

        public static void KenaikanGaji(Karyawan pertama, Karyawan kedua)
        {
            int tambah = pertama.gaji * 10 / 100;
            pertama.gaji += tambah;
            int tambah1 = kedua.gaji * 10 / 100;
            kedua.gaji += tambah1;
        }

        public static void HasilGaji(Karyawan pertama, Karyawan kedua)
        {
            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%!!");
            Console.WriteLine("");
            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. {0} {1} \t {2}", pertama.id, pertama.nama, pertama.gaji);
            Console.WriteLine("2. {0} {1} \t {2}", kedua.id, kedua.nama, kedua.gaji);
        }
    }
}
