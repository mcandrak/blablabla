using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days1
    {
        public void Days1Exam1()
        {
            Console.Write("\nJawaban Exam 1 Day 1");
            Console.Write("\nMasukkan harga baju      : ");
            decimal hargaBaju = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Masukkan harga celana    : ");
            decimal hargaCelana = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nMasukkan jumlah diskon gopay : ");
            int diskonGopay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan jumlah diskon ovo   : ");
            int diskonOvo = Convert.ToInt32(Console.ReadLine());

            //mencetak diskon
            Console.WriteLine("\n- Diskon " + diskonGopay + "% jika bayar menggunakan Gopay");
            Console.WriteLine("- Diskon " + diskonOvo + "% jika bayar menggunakan Ovo");

            //menghitung jumlah harga
            decimal jumlahHarga = hargaBaju + hargaCelana;

            //memilih metode
            Console.Write("\nPilih Metode Pembayaran : ");

            decimal jumlahDiskon = 0;
            string metodePembayaran = Console.ReadLine().ToLower();

            switch (metodePembayaran)
            {
                case "gopay":
                    jumlahDiskon = Common.FnHitungDiskon(jumlahHarga, diskonGopay);
                    break;
                case "ovo":
                    jumlahDiskon = Common.FnHitungDiskon(jumlahHarga, diskonOvo);
                    break;
                default:
                    break;
            }

            //cetak belanjaan dan harga
            Console.WriteLine("\nHarga baju           : Rp." + hargaBaju);
            Console.WriteLine("Harga Celana         : Rp." + hargaCelana);
            Console.WriteLine("                     _____________ +");
            Console.WriteLine("Total awal           : Rp." + jumlahHarga);
            Console.WriteLine("Potongan harga       : Rp." + jumlahDiskon);
            decimal hargaSetelahDiskon = jumlahHarga - jumlahDiskon; ;
            Console.WriteLine("                     _____________ -");
            Console.WriteLine("Total akhir          : Rp." + hargaSetelahDiskon);
        }

        public void Days1Exam2()
        {
            Console.Write("\nJawaban Exam 2 Day 1");
            Console.Write("Masukkan jumlah tepung terigu    : ");
            double jumlahTepungTerigu = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan jumlah gula pasir       : ");
            double jumlahGulaPasir = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan jumlah susu murni       : ");
            double jumlahSusuMurni = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan jumlah putih telur      : ");
            double jumlahPutihTelur = Convert.ToDouble(Console.ReadLine());

            double tepungTeriguEmpatKue = jumlahTepungTerigu / 15 * 4;
            double gulaPasirEmpatKue = jumlahGulaPasir / 15 * 4;
            double susuMurniEmpatKue = jumlahSusuMurni / 15 * 4;
            double putihTelurEmpatKue = jumlahPutihTelur / 15 * 4;
            double totalBahan = tepungTeriguEmpatKue + gulaPasirEmpatKue + susuMurniEmpatKue + putihTelurEmpatKue;

            Console.WriteLine("\nBahan yang dibutuhkan untuk membuat 4 kue pukis\n");
            Console.WriteLine("1. tepung terigu         : " + Math.Round(tepungTeriguEmpatKue, 2) + " gram");
            Console.WriteLine("2. Total gula pasir      : " + Math.Round(gulaPasirEmpatKue, 2) + " gram");
            Console.WriteLine("3. Total susu murni      : " + Math.Round(susuMurniEmpatKue, 2) + " gram");
            Console.WriteLine("4. Total putih telur     : " + Math.Round(putihTelurEmpatKue, 2) + " gram");

            Console.WriteLine("\nTotal Bahan            : " + Math.Round(totalBahan, 2) + " gram");
        }

        public void Days1Exam3()
        {
            Console.Write("\nJawaban Exam 3 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = -1;
            int[] arrayHasil = new int[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a + 2;
                arrayHasil[i] = a;
            }
            Console.WriteLine("Output : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam4()
        {
            Console.Write("\nJawaban Exam 4 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int[] arrayHasil = new int[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a + 2;
                arrayHasil[i] = a;
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam5()
        {
            Console.Write("\nJawaban Exam 5 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = -2;
            int[] arrayHasil = new int[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a + 3;
                arrayHasil[i] = a;
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam6()
        {
            Console.Write("\nJawaban Exam 6 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = -3;
            string[] arrayHasil = new string[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                if (i % 3 == 2)
                {
                    a = a + 0;
                    arrayHasil[i] = "*";
                }
                else
                {
                    a = a + 4;
                    string angka = Convert.ToString(a);
                    arrayHasil[i] = angka;
                }
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam7()
        {
            Console.Write("\nJawaban Exam 7 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = -3;
            string[] arrayHasil = new string[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a + 4;

                if (i % 3 == 2)
                {
                    arrayHasil[i] = "*";
                }
                else
                {
                    string angka = Convert.ToString(a);
                    arrayHasil[i] = angka;
                }
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam8()
        {
            Console.Write("\nJawaban Exam 8 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int[] arrayHasil = new int[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a * 2;
                arrayHasil[i] = a;
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam9()
        {
            Console.Write("\nJawaban Exam 9 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int[] arrayHasil = new int[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a * 3;
                arrayHasil[i] = a;
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam10()
        {
            Console.Write("\nJawaban Exam 10 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            string[] arrayHasil = new string[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                if (i == 2 || i == 5)
                {
                    a = a * 1;
                    arrayHasil[i] = "*";
                }
                else
                {
                    a = a * 4;
                    string angka = Convert.ToString(a);
                    arrayHasil[i] = angka;
                }
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam11()
        {
            Console.Write("\nJawaban Exam 11 Day 1");
            Console.Write("\nMasukkan jumlah pengulangan : ");
            int jmlPengulangan = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            string[] arrayHasil = new string[jmlPengulangan];
            for (int i = 0; i < jmlPengulangan; i++)
            {
                a = a * 3;

                if (i == 3)
                {
                    arrayHasil[i] = "XXX";
                }
                else
                {
                    string angka = Convert.ToString(a);
                    arrayHasil[i] = angka;
                }
            }
            Console.WriteLine("\nOuttput : " + string.Join(" ", arrayHasil));
        }

        public void Days1Exam12()
        {
            // dari input string -> tampilan console (tidak ada penyimpanan ke array karena tidak ada penentuan angka pertama)
            // 1) input panjang data
            Console.WriteLine();
            Console.WriteLine("Masukkan panjang data yang diinginkan: ");
            int primeArrMax = Convert.ToInt32(Console.ReadLine());
            #region Core Algorithm
            // counter jumlah bilangan prima sesuai jumlah yang diinginkan
            int jmlNol = 0;
            int mod; // nilai modulus untuk pengetesan
            int primeCounter = 0;
            int dinamis = 100 * primeArrMax;
            // 2) Pengujian angka
            // Tidak boleh dibagi nol.
            for (int i = 1; i <= dinamis; i++) // bilangan yang akan dites. kalau mulai dari 1 pakai kurang sama dengan.
            {
                for (int j = 1; j <= i; j++) // bilangan pengetes/pembagi yang akan mengetes status prima bilangan i
                {
                    if (i > j)
                    {
                        mod = i % j; // cek modulus
                        if (mod == 0)
                        {
                            jmlNol += 1; // counter modulus nol yang terdeteksi
                        }
                    }
                }
                if (jmlNol == 1) // kalau sama dengan 1 = prima
                {
                    Console.Write(i + " ");
                    primeCounter += 1;
                }
                jmlNol = 0; // reset jumlah modulus nol dari setiap bilangan yang dites
                if (primeCounter == primeArrMax)
                {
                    break;
                }
            }
            #endregion
            Console.WriteLine();
        }


    }
}
