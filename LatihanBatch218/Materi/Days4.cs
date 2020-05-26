using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days4
    {
        public void Days4Exam1()
        {
            #region
            //DateTime dt = DateTime.Now;
            //int tanggal = dt.Day;
            //int bulan = dt.Month;
            //int tahun = dt.Year;
            //int jmlHariOkt = DateTime.DaysInMonth(tahun, 10);
            //int sisaHari = jmlHariOkt - tanggal;

            //string tampilan1 = dt.ToString("dddd,dd MMMM yyyy");
            #endregion

            #region cara 1
            ////1. total hari bulan ganjil jan, mar, jul, sept
            //int ganjil = 1;
            //int jmlGanjil = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (i != 2)
            //    {
            //        jmlGanjil += DateTime.DaysInMonth(2019, ganjil);
            //        ganjil = ganjil + 2;
            //    }
            //}
            //Console.WriteLine("(1) ganjil : " + jmlGanjil);
            //Console.WriteLine();

            ////2. total hari bulan genap apr, jun, agst, okt, des
            //int genap = 4;
            //int jmlGenap = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    jmlGenap += DateTime.DaysInMonth(2019, genap);
            //    genap = genap + 2;
            //}
            //Console.WriteLine("(2) genap : " + jmlGenap);
            //Console.WriteLine();
            #endregion

            #region cara 2

            //int ttlGenap = 0;
            //int ttlGanjil = 0;
            //int[] arrGenap = new int[12];
            //int[] arrGanjil = new int[12];
            //for (int j = 1; j <= 12; j++)
            //{
            //    if (j % 2 == 0) // genap
            //    {
            //        if (j >= 4)
            //        {
            //            arrGenap[j - 1] = DateTime.DaysInMonth(2019, j);
            //            ttlGenap += arrGenap[j - 1];
            //        }
            //    }
            //    else //ganjil
            //    {
            //        if (j != 5)
            //        {
            //            arrGanjil[j-1] += DateTime.DaysInMonth(2019, j);
            //            ttlGanjil += arrGanjil[j-1];

            //        }
            //    }
            //}

            //Console.WriteLine("\nCara 2");
            //Console.Write("(1)" + string.Join(" + ", arrGenap));
            //Console.Write(" = " + ttlGenap);
            //Console.Write("\n\n(2)" + string.Join(" + ", arrGanjil));
            //Console.Write(" = " + ttlGanjil);


            #endregion

            #region cara 3
            string ketBulanGenap = string.Empty, ketBulanGanjil = string.Empty;
            int jmlHariBulanGenap = 0, jmlHariBulanGanjil = 0;
            DateTime dt = DateTime.Now;
            for (int i = 1; i <= 12; i++)
            {
                if (i % 2 == 0)
                {
                    if (i >= 4)
                    {
                        jmlHariBulanGenap += DateTime.DaysInMonth(dt.Year, i);
                        if (string.IsNullOrEmpty(ketBulanGenap))
                        {
                            ketBulanGenap += DateTime.DaysInMonth(dt.Year, i);
                        }
                        else
                        {
                            ketBulanGenap += " + " + DateTime.DaysInMonth(dt.Year, i);
                        }
                    }
                }
                else
                {
                    if (i != 5)
                    {
                        jmlHariBulanGanjil += DateTime.DaysInMonth(dt.Year, i);
                        if (string.IsNullOrEmpty(ketBulanGanjil))
                        {
                            ketBulanGanjil += DateTime.DaysInMonth(dt.Year, i);
                        }
                        else
                        {
                            ketBulanGanjil += " + " + DateTime.DaysInMonth(dt.Year, i);
                        }
                    }
                }
            }

            Console.WriteLine("Bulan Ganjil : " + ketBulanGanjil + " = " + jmlHariBulanGanjil);
            Console.WriteLine("Bulan Genap : " + ketBulanGenap + " = " + jmlHariBulanGenap);
            #endregion
        }

        public void Days4Exam2()
        {
            #region
            Console.WriteLine("Jawaban Exam 2 Day 4");
            Console.Write("\nMasukkan Jam Keberangkatan ");
            Console.Write("\nJam : ");
            int leaveHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Menit : ");
            int leaveMinute = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMasukkan lamanya perjalanan (dalam menit) : ");
            int duration = Convert.ToInt32(Console.ReadLine());
            
            //convert minutes to hours
            var duration2 = TimeSpan.FromMinutes(duration);

            TimeSpan leaveTime = new TimeSpan(leaveHour, leaveMinute,0);
            TimeSpan arriveTime = leaveTime.Add(duration2);

            Console.WriteLine("\nSampai di kota B = " + leaveTime + " + " + duration2 + " = " + arriveTime );
            #endregion
        }

        public void Days4Exam3()
        {
            Console.WriteLine("Jawaban Exam 3 Day 4");
            #region cara 1
            //Console.Write("\nMasukkan Jam Berangkat ");
            //Console.Write("\nJam : ");
            //int leaveHour = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Menit : ");
            //int leaveMinute = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nMasukkan Jam Pulang ");
            //Console.Write("\nJam : ");
            //int goHomeHour = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Menit : ");
            //int goHomeMinute = Convert.ToInt32(Console.ReadLine());

            //TimeSpan leaveTime = new TimeSpan(leaveHour, leaveMinute, 0);
            //TimeSpan goHomeTime = new TimeSpan(goHomeHour, goHomeMinute, 0);
            #endregion

            #region cara 2
            while (true)
            {
                Console.Write("\nMasukkan Jam Berangkat (hh.mm) : ");
                string inp1 = Console.ReadLine();
                string[] arrLeaveTime = inp1.Split('.');

                Console.Write("\nMasukkan Jam Pulang (hh.mm) :  ");
                string inp2 = Console.ReadLine();
                string[] arrArriveTime = inp2.Split('.');

                if (Convert.ToInt32(arrLeaveTime[0]) > Convert.ToInt32(arrArriveTime[0]))
                {
                    Console.WriteLine("\nWaktu berangkat tidak boleh lebih besar dari waktu pulang");
                }
                else
                {
                    TimeSpan leaveTime = new TimeSpan(Convert.ToInt32(arrLeaveTime[0]), Convert.ToInt32(arrLeaveTime[1]), 0);
                    TimeSpan goHomeTime = new TimeSpan(Convert.ToInt32(arrArriveTime[0]), Convert.ToInt32(arrArriveTime[1]), 0);

                    TimeSpan duration = goHomeTime.Subtract(leaveTime);
                    Console.WriteLine("\nLama Ihsan les = " + duration.Hours + " Jam " + duration.Minutes + " Menit");
                    break;
                }
            }
            #endregion
        }

        public void Days4Exam4()
        {
            Console.WriteLine("Jawaban Exam 4 Day 4");

            #region cara 1
            //Console.Write("\nMasukkan Jam Berangkat ");
            //Console.Write("\nJam : ");
            //int leaveHour = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Menit : ");
            //int leaveMinute = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nMasukkan Jam Pulang ");
            //Console.Write("\nJam : ");
            //int goHomeHour = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Menit : ");
            //int goHomeMinute = Convert.ToInt32(Console.ReadLine());

            //TimeSpan leaveTime = new TimeSpan(leaveHour, leaveMinute, 0);
            //TimeSpan goHomeTime = new TimeSpan(goHomeHour, goHomeMinute, 0);
            #endregion

            #region cara 2
            Console.Write("\nMasukkan Jam Berangkat (hh.mm) : ");
            string inp1 = Console.ReadLine();
            string[] arrLeaveTime = inp1.Split('.');

            Console.Write("\nMasukkan Jam Pulang (hh.mm) :  ");
            string inp2 = Console.ReadLine();
            string[] arrArriveTime = inp2.Split('.');

            TimeSpan leaveTime = new TimeSpan(Convert.ToInt32(arrLeaveTime[0]), Convert.ToInt32(arrLeaveTime[1]), 0);
            TimeSpan goHomeTime = new TimeSpan(Convert.ToInt32(arrArriveTime[0]), Convert.ToInt32(arrArriveTime[1]), 0);

            #endregion

            TimeSpan duration = goHomeTime - leaveTime;
            
            Console.WriteLine("\n"+ duration.Hours + " Jam " + duration.Minutes + " Menit");
        }

        public void Days4Exam5()
        {
            Console.WriteLine("Jawaban Exam 5 Day 4");

            #region cara 1
            //Console.Write("\nMasukkan Usia yang lalu (satuan tahun): ");
            //double age1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("\nMasukkan durasi lalu (satuan tahun) : ");
            //double duration1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("\nMasukkan durasi yang akan datang (satuan bulan) : ");
            //double duration2 = Convert.ToDouble(Console.ReadLine());

            //double age2 = age1 + duration1 + (duration2 /12);

            //Console.WriteLine("\nUmur Irma : {0} + {1} + {2} = {3} tahun", age1, duration1, duration2/12, age2);
            #endregion

            #region cara 2
            Console.Write("\nMasukkan Usia yang lalu: ");
            double age1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nMasukkan durasi lalu (satuan tahun) : ");
            double duration1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nMasukkan durasi yang akan datang (satuan bulan) : ");
            double duration2 = Convert.ToDouble(Console.ReadLine());

            double age2 = age1 + duration1 + (duration2 / 12);

            Console.WriteLine("\nUmur Irma : {0} + {1} + {2} = {3} tahun", age1, duration1, duration2 / 12, age2);

            #endregion

        }

        public void Days4Exam6()
        {
            Console.WriteLine("\nJawaban Exam 6 Day 4");
            
        }
    }
}
