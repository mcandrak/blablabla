using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days5
    {
        public void Days5Exam1()
        {
            Console.WriteLine("Jawaban Exam 1 Day 5");
            Console.Write("\nMasukkan batas awal : ");
            int startRange = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan batas akhir : ");
            int endRange = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.Write("\nMasukkan  angka anda ({0}-{1}) : ", startRange, endRange);
                int userVal = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int compVal = rnd.Next(startRange, endRange);

                if (userVal > endRange || userVal < startRange)
                {
                    Console.WriteLine("\nAngka yang anda masukkan harus dalam range 0-9!!)");
                }
                else
                {
                    Console.WriteLine("\nAngka komputer             : " + compVal);

                    if (userVal > compVal)
                    {
                        Console.WriteLine("\nSelamat anda menang!!!! :)");
                    }
                    else if (userVal == compVal)
                    {
                        Console.WriteLine("\nHasil seri :)");
                    }
                    else
                    {
                        Console.WriteLine("\nAnda kalah :(");
                    }
                    
                    Console.Write("\nBermain lagi (y/n) ? ");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        break;
                    }
                }
            }
        }

        public void Days5Exam2()
        {
            Console.WriteLine("Jawaban Exam 2 Day 5");

            #region cara 1
            //Console.Write("\nMasukkan jarak masing-masing rute (dalam km) ");
            //Console.Write("\nrute 1 : ");
            //double rute1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("\nrute 2 : ");
            //double rute2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("\nrute 3 : ");
            //double rute3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("\n\nMasukkan jarak yang bisa ditempuh dengan 1 liter : ");
            //double jrk1Liter = Convert.ToDouble(Console.ReadLine());

            //double ttlRute = rute1 + rute2 + rute3;

            //double bensin = Common.FnHitungBensin(ttlRute, jrk1Liter);

            //Console.WriteLine("\nBensin yang dibutuhkan untuk bisa kembali ke titik awal = " + bensin + " liter");
            #endregion

            #region cara 2
            double distance, ttlDistance = 0;
            int status = 1;
            while (status >= 1 && status <= 4)
            {
                Console.Write("\nMasukkan jarak : ");
                distance = Convert.ToDouble(Console.ReadLine());
                if (distance >= 1000)
                {
                    distance = distance / 1000;
                }
                ttlDistance = ttlDistance + distance;
                status++;
                Console.Write("\nMau menambahkan jarak lain (y/n) ? ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }

            Console.Write("\n\nTotal jarak tempuh : " + ttlDistance * 2);
            Console.Write("\n\nMasukkan jarak yang bisa ditempuh dengan 1 liter : ");
            double jrk1Liter = Convert.ToDouble(Console.ReadLine());

            double bensin = Common.FnHitungBensin(ttlDistance, jrk1Liter);
            Console.WriteLine("\nBensin yang dibutuhkan untuk bisa kembali ke titik awal = " + bensin + " liter");
            #endregion

        }
    }
}
