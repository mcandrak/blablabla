using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days7
    {
        public void Days7Exam1()
        {
            /*input array size*/
            Console.Write("\nMasukkan panjang baris : ");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            /*input the value of array 1 */
            Console.Write("\nMasukkan nilai deret baris 1 : ");
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '),
            arrTemp => Convert.ToInt32(arrTemp));
            
            /*input the value of array 2*/
            Console.Write("\nMasukkan nilai deret baris 1 : ");
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '),
            arrTemp => Convert.ToInt32(arrTemp));

            /*define new array to for output*/
            int[] arrOutput = new int[arrSize];

            if (arr1.Length != arrSize)//if array input dont same with array size
            {
                Console.WriteLine("\njumlah inputan deret baris harus sama dengan inputan panjang baris!!");
            }
            else //if array input same with array size
            {
                /*sum for value of array 1 and array 2 for each same index*/
                for (int i = 0; i < arrSize; i++)
                {
                    arrOutput[i] = arr1[i] + arr2[i];
                }
                /*print the output*/
                Console.WriteLine("\nOutput     : " + string.Join(" ", arrOutput));
            }
        }

        public void Days7Exam2()
        {
            /*input how many cage*/
            Console.Write("\nMasukkan banyak kandang : ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            
            /*input how many animal in each cage*/
            Console.Write("\nMasukkan jumlah isi masing-masing kandang : ");
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '),
            arrTemp => Convert.ToInt32(arrTemp));
            
            /*input what kind of animal in each cage*/
            Console.Write("\nMasukkan jenis hewan masing-masing kandang : ");
            string[] arr2 = Console.ReadLine().Split(' ');

            /*sum all the animal in each cage*/
            int sum = 0;
            for (int i = 0; i < arrSize; i++)
            {
                sum += arr1[i];
            }

            /*input which cage are being sold*/
            Console.Write("\nMasukkan nomor kandang yang dibeli : ");
            int sold = Convert.ToInt32(Console.ReadLine());

            /*calculate the rest of animal*/
            int restAnimals = sum - arr1[sold-1];

            /*print output how many the rest of animal*/
            Console.WriteLine("\ntotal jumlah hewan yang ada di toko : " + restAnimals);
            Console.WriteLine("\ndengan rincian : ");
            for (int i = 0; i < arrSize; i++)
            {
                if (i != sold-1)
                {
                    Console.WriteLine("Kandang {0} = {1} {2}", (i + 1), arr1[i], arr2[i]);
                }
            }
        }

        public void Days7Exam3()
        {
            double s1, s2, s3, s4, sTotal, s1Liter;
            /**/
            Console.Write("\nMasukkan jam berangkat dari rumah(hh.mm) : ");
            int[] leave = Array.ConvertAll(Console.ReadLine().Split('.'),
            arrTemp => Convert.ToInt32(arrTemp));

            /**/
            Console.Write("\nMasukkan jam tiba dirumah(hh.mm) : ");
            int[] arrived = Array.ConvertAll(Console.ReadLine().Split('.'),
            arrTemp => Convert.ToInt32(arrTemp));

            TimeSpan leaveHome = new TimeSpan(leave[0], leave[1], 0);
            TimeSpan arrivedAtHome = new TimeSpan(arrived[0], arrived[1], 0);

            TimeSpan totalTime = arrivedAtHome - leaveHome;

            Console.Write("\nMasukkan jarak dari kemang ke langsat : ");
            s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nMasukkan jarak dari langsat ke kalbefarma : ");
            s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nMasukkan jarak dari kalbefarma ke langsat : ");
            s3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nMasukkan jarak dari langsat ke kemang : ");
            s4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nMasukkan jarak yang ditempuh untuk 1 liter BBM : ");
            s1Liter = Convert.ToDouble(Console.ReadLine());

            sTotal = s1 + s2 + s3 + s4;

            Console.WriteLine("\n Total waktu yang ditempuh Lulut : {0} jam {1} menit ", totalTime.Hours, totalTime.Minutes );
            Console.WriteLine("\n Total jarak yang ditempuh Lulut : {0} KM ", sTotal );
            Console.WriteLine("\n Total BBM : {0} Liter ", sTotal/s1Liter );
        }

        public void Days7Exam4()
        {
            Console.WriteLine("Pilihan Konversi : \n");

            Console.WriteLine("1.Galon ke Teko");
            Console.WriteLine("2.Galon ke Botol");
            Console.WriteLine("3.Galon ke Gelas\n");

            Console.WriteLine("4.Teko ke Galon");
            Console.WriteLine("5.Teko ke Botol");
            Console.WriteLine("6.Teko ke Gelas\n");
            
            Console.WriteLine("7.Botol ke Galon");
            Console.WriteLine("8.Botol ke Teko");
            Console.WriteLine("9.Botol ke Gelas\n");
            
            Console.WriteLine("10.Gelas ke Galon");
            Console.WriteLine("11.Gelas ke Teko");
            Console.WriteLine("12.Gelas ke Botol\n");

            Console.Write("\n\nMasukkan pilihan : ");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            Common.FnKonversi(caseSwitch);


        }

        public void Days7Exam5()
        {
            Console.Write("Masukkan angka : ");
            string input = Console.ReadLine();

            string kata = string.Empty;
            /* memberi pemisah pada string*/
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    kata += input[i];
                    kata += " ";
                }
            }

            string[] arr1 = kata.Split(' ');
            int[] arrVal1 = new int[arr1.Length - 1];
            int total = 0;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                string temp = arr1[i];
                arrVal1[i] = Convert.ToInt32(temp);
                total += arrVal1[i];
            }

            Console.WriteLine("\nPenjumlahan Pertama : "+ string.Join("+", arrVal1) + " = " + total);

            string input2 = total.ToString();
            int total2 = 0;
            if (input2.Length > 1)
            {
                string kata2 = string.Empty;
                for (int a = 0; a < input2.Length; a++)
                {
                    kata2 += input2[a];
                    kata2 += " ";
                }

                string[] arr2 = kata2.Split(' ');
                int[] arrVal2 = new int[arr2.Length - 1];
                for (int a = 0; a < arr2.Length-1; a++)
                {
                    string temp = arr2[a];
                    arrVal2[a] = Convert.ToInt32(temp);
                    total2 += arrVal2[a];
                }
                Console.WriteLine("\nPenjumalahan kedua : " + string.Join("+", arrVal2) + " = " + total2);
            }

            string input3 = Convert.ToString(total2);
            int total3 = 0;
            if (input3.Length > 1)
            {
                string kata3 = string.Empty;
                for (int a = 0; a < input3.Length; a++)
                {
                    kata3 += input3[a];
                    kata3 += " ";
                }

                string[] arr3 = kata3.Split(' ');
                int[] arrVal3 = new int[arr3.Length - 1];
                for (int a = 0; a < arr3.Length - 1; a++)
                {
                    string temp = arr3[a];
                    arrVal3[a] = Convert.ToInt32(temp);
                    total3 += arrVal3[a];
                }
                Console.WriteLine("\nPenjumalahan Ketiga : " + string.Join("+", arrVal3) + " = " + total3);
            }
        }

        public void Days7Exam6()
        {
            /*input array size*/
            Console.Write("\nMasukkan panjang array : ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            
            int status = 0;
            while (status <= 10)
            {
                /*input the value of array 1 */
                Console.Write("\nMasukkan nilai deret : ");
                int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '),
                arrTemp => Convert.ToInt32(arrTemp));

                if (arrSize != arr1.Length)
                {
                    Console.WriteLine("\nJumlah deret yang dimasukkan harus sama dengan panjang array!!");
                    status++;
                }
                else
                {
                    int temp;
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (i < 3)
                        {
                            temp = arr1[i];
                            arr1[i] = arr1[i + 2];
                            arr1[i + 2] = temp;
                        }
                        if (i == 3)
                        {
                            temp = arr1[i];
                            arr1[i] = arr1[i + 1];
                            arr1[i + 1] = temp;
                        }
                    }
                    Console.WriteLine(string.Join(" ", arr1));
                    break;
                }
            }
        }

        public void Days7Exam7()
        {
            Console.Write("\nMasukkan ");
        }

        
        public void Days7Exam8()
        {
            int a = 24, b = 54, c = 90;
            Console.WriteLine();
            Common.FnFactorial(a);
            Console.WriteLine();
            Common.FnFactorial(b);
            Console.WriteLine();
            Common.FnFactorial(c);
        }
        
        public void Days7Exam9()
        {
            string[,] Petunjuk = new string[3, 2]
            {
                {"Sejarah", "3" },
                {"MTK", "5" },
                {"Biologi", "4" }
            };

            Console.WriteLine("\nJudul\tMax Hari Pinjam");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Petunjuk[i, 0] + "\t\t" + Petunjuk[i, 1]);
            }

            Console.Write("\nMasukkan Tanggal Pinjam [contoh : dd/MM/YY]\t: ");
            string inpDatePinjam = Console.ReadLine();
            Console.Write("\nMasukkan Tanggal Kembali [contoh : dd/MM/YY]\t: ");
            string inpDateKembali = Console.ReadLine();

            DateTime datePinjam = DateTime.Parse(inpDatePinjam);
            DateTime dateKembali = DateTime.Parse(inpDateKembali);

            int ttlHariPinjam = (int)(dateKembali - datePinjam).TotalDays;
            double ttlOverdue = 0;
            //double denda = 0;
            Console.WriteLine("\nJudul\t\tMax Hari Pinjam\t\tDur.\tOverdue");
            for (int i = 0; i < 3; i++)
            {
                string Judul = Petunjuk[i, 0];
                int maxDay = Convert.ToInt32(Petunjuk[i, 1]);
                double durasi = ttlHariPinjam;
                double overdue = durasi - maxDay;
                if (overdue < 0)
                {
                    overdue = 0;
                }
                ttlOverdue += overdue;
                Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t{3}", Judul, maxDay, durasi, overdue);
            }

            Console.Write("\nDenda\t: 250 * {0} = {1}", ttlOverdue, ttlOverdue*250);

        }

        public void Days7Exam10()
        {
            Console.Write("masukkan kata pertama : ");
            string kata1 = Console.ReadLine();
            Console.Write("masukkan kata kedua : ");
            string kata2 = Console.ReadLine();

            if (kata1.Length <3 || kata2.Length < 3)
            {
                Console.WriteLine("masukkan kata minimal 3 karakter!!");
            }
            else
            {
                if (kata1 == kata2)
                {
                    Console.WriteLine("Hasilnya : YES");
                }
                else
                {
                    string status = "No";
                    for (int i = 0; i < kata1.Length; i++)
                    {
                        for (int j = 0; j < kata1.Length; j++)
                        {
                            if (kata1[i] == kata2[j])
                            {
                                Console.WriteLine(kata1[i] + " == " + kata2[j]);
                                status = "YES";
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Hasilnya : " + status);
                }
                
            }
            
        }

        public void Days7Exam11() //nomor 5 cara 2
        {
            Console.Write("Masukkan angka : ");
            string input = Console.ReadLine();
            string kata = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                kata += input;
            }

            string[] arrKata = kata.Split();

            int total = 0;
            for (int i = 0; i < kata.Length ; i++)
            {
                total += Convert.ToInt32(kata[i].ToString());
            }

            Console.WriteLine("\nPenjumlahan Ke-1 : " + string.Join("+", arrKata) + " = " + total);

            string hasil = total.ToString();
            Common.FnRekursifSimulasi5(hasil, 1);
        }

        public void Days7Exam12() //nomor 6 cara 2
        {
            Console.Write("\nMasukkan panjang Array : ");
            Console.Write("\nMasukkan nilai deret : ");
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '),
            arrTemp => Convert.ToInt32(arrTemp));

            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length - 2; i++)
            {
                arr2[i] = arr1[i + 2];
            }

            int a = arr1.Length - 2;
            for (int j = arr1.Length - 2; j < arr1.Length; j++)
            {
                arr2[j] = arr1[j - a];
            }

            Console.WriteLine(string.Join(" ", arr2));
        }

        public void Days7Exam13() //nomor 6 cara 3
        {
            int max = 0;
            while (max < 10)
            {
                Console.Write("\nMasukkan isi array minimal angka (contoh 1,2,3,..,dst) : ");
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(','),
                arrTemp => Convert.ToInt32(arrTemp));

                if (arr.Length< 6)
                {
                    Console.WriteLine("\nMasukkan minimal 5 angka !!!!!");
                    max++;
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        //Console.WriteLine((2 + i) % arrSize);
                        int index = (2 + i) % arr.Length;
                        Console.Write(arr[index] + " ");
                    }
                    break;
                }
            }
        }

        public void Days7Exam14()
        {
            Console.WriteLine("Ada inputan sebanyak 2x, lalu cek apakah kata-katanya sama? jika tidak apakah perhurufnya ada yang sama? jika ya cetak 'Yes', jika tidak cetak 'No'.");
            /* mendapatkan inputan ke 1 dan  ke 2 */
            Console.Write("\nMasukkan Kata Pertama : ");
            string firstWord = Console.ReadLine();
            Console.Write("Masukkan kata Kedua : ");
            string secondWord = Console.ReadLine();
            /* pengecekan apakah kedua inputan panjangnya kurang dari 3 */
            if (firstWord.Length < 3 || secondWord.Length < 3)
            {
                Console.WriteLine("Panjang kata minimal 3 karakter"); //cetak karena nilain
            }
            else
            {
                /* pengecekan apakah ada kata yang sama ? */
                if (firstWord == secondWord)
                {
                    Console.WriteLine("Hasil pengecekan    : Yes");
                }
                else
                {
                    /* cara manual */
                    string statusCheck = "No";
                    foreach (char perkata1 in firstWord)
                    {
                        if (statusCheck == "No")
                        {
                            foreach (char perkata2 in secondWord)
                            {
                                if (perkata1 == perkata2)
                                {
                                    statusCheck = "Yes";
                                    break;
                                }
                            }
                        }
                    }
                    /* cetak status chek */
                    Console.WriteLine("Hasil pengecekan    : " + statusCheck);
                }
            }
        }
    }
}
