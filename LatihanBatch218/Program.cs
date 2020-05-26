using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLatihan Logic");

            //memanggil populate data soal
            List<Exam> generateExam = Exam.PopulateDataExam();

            int countUlang = 1;
            for (int i = 0; i < countUlang; i++)
            {
                if (i == 0)
                {
                    ShowDaysExams(generateExam);
                    countUlang++;
                }
                else
                {
                    Console.Write("\nMau lanjut ke soal lain ? (y/n) ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        ShowDaysExams(generateExam);
                        countUlang++;
                    }
                }
            }

            Console.ReadKey();
        }

        static void ShowDaysExams(List<Exam> paramListExam)
        {
            Exam.GetListDays(paramListExam);
            Int32 inputDay = Convert.ToInt32(Console.ReadLine());

            Exam.GetListExam(paramListExam, inputDay);
            Int32 InputExam = Convert.ToInt32(Console.ReadLine());

            string namaClass = "Materi.Days" + inputDay;
            string namaMethod = "Days" + inputDay + "Exam" + InputExam; //Days1Exam1
            Exam.GetListExamDetails(paramListExam, inputDay, InputExam);

            CallDynamicMethod("LatihanBatch218." + namaClass, namaMethod);
        }

        static void CallDynamicMethod(String objectClass, String methodName)
        {
            Type type = Type.GetType(objectClass);
            Object obj = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod(methodName);
            methodInfo.Invoke(obj, null);
        }
    }

    public class Exam
    {
        public Int32 DaysNo { get; set; }
        public string DaysDesc { get; set; }
        public Int32 ExamNo { get; set; }
        public string ExamDesc { get; set; }
        public string ExamDetails { get; set; }

        public static List<Exam> PopulateDataExam()
        {
            List<Exam> listExam = new List<Exam>();
            listExam.Add(new Exam { 
                DaysNo = 1,
                DaysDesc = "Days ",
                ExamNo = 1,
                ExamDesc = "Exam ",
                ExamDetails = "seorang wanita membeli sepasang baju dan celana dengan harga baju Rp. 125.000" + 
                              "\ndan celana Rp. 429.990. dia akan mendapatkan diskon 10% jika menggunakan gopay" +
                              "\ndan diskon 20% jika menggunakan OVO." +
                              "\ndiminta" +
                              "\n1.ada inputan harga baju dan celana." +
                              "\n2.ada inputan besaran persenan diskon masing - masing pembayaran." +
                              "\n3.tampilkan keterangan diskon masing - masing pembayaran." +
                              "\n4.tampilkan barang belanjaannya dengan harganya dan total harga yang harus dibayarkan." +
                              "\n5.tampilkan harga yang didiskon."
            });
            
            listExam.Add(new Exam
            {
                DaysNo = 1,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "nama dan jumlah bahan untuk membuat 15 kue pukis :" +
                              "\n- tepung terigu     125 gram" +
                              "\n- gula pasir        100 gram" +
                              "\n- susu murni        100 gram" +
                              "\n- putih telur ayam  100 gram" +
                              "\nberapa jumlah bahan yang digunakan untuk membuat 1 kue pukis ?"
            });

            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 3, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 1 3 5 7 9 11 13" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 4, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 2 4 6 8 10 12 14 1" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 5, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 1 4 7 10 13 16 19" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 6, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 1 5 * 9 13 * 17" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 7, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 1 5 * 13 17 * 25" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 8, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 2 4 8 16 32 64 128 " });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 9, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 3 9 27 81 234 729 2187" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 10, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 4 16 * 64 256 * 1024" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 11, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 3 9 27 XXX 243 729 2187" });
            listExam.Add(new Exam{ DaysNo = 1, DaysDesc = "Days ", ExamNo = 12, ExamDesc = "Exam ", ExamDetails = "N=7 diminta output 2 3 5 7 11 13 17" });

            listExam.Add(new Exam{ 
                DaysNo = 2, 
                DaysDesc = "Days ", 
                ExamNo = 1, 
                ExamDesc = "Exam ", 
                ExamDetails = "input : Aku Sayang Kamu" +
                              "\noutput : A*u S****g K**u"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "input : Tapi saya Tidak Sayang KAMU!!" +
                              "\noutput : 7"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 3,
                ExamDesc = "Exam ",
                ExamDetails = "input : aku mau makan" +
                              "\noutput : A** M** M****"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 4,
                ExamDesc = "Exam ",
                ExamDetails = "input : aku mau mandi" +
                              "\noutput : **U **U ****I"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 5,
                ExamDesc = "Exam ",
                ExamDetails = "input : habis makan kenyang" +
                              "\noutput : B*** K*** N***"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 6,
                ExamDesc = "Exam ",
                ExamDetails = "input : saya pasti bisa" +
                              "\noutput : YA STI SA"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 7,
                ExamDesc = "Exam ",
                ExamDetails = "input : PT. XSIS MITRA UTAMA" +
                              "\noutput : 1"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 8,
                ExamDesc = "Exam ",
                ExamDetails = "input : abuba" +
                              "\noutput : abuba"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 9,
                ExamDesc = "Exam ",
                ExamDetails = "input : ManTuL bingits" +
                              "\noutput : almntu bgiinst"
            });
            listExam.Add(new Exam
            {
                DaysNo = 2,
                DaysDesc = "Days ",
                ExamNo = 10,
                ExamDesc = "Exam ",
                ExamDetails = "input : kerupuk udang balado" +
                              "\noutput : k***k u***g b***o"
            });

            listExam.Add(new Exam
            {
                DaysNo = 3,
                DaysDesc = "Days ",
                ExamNo = 1,
                ExamDesc = "Exam ",
                ExamDetails = "Buatlah algoritma yang menginputkan 7 bilangan yang merupakan" +
                              "\nnilai ujian mahasiswa, mencetak nilai tertinggi yang didapat" +
                              "\nmahasiswa dan juga mencetak berapa orang yang mendapat nilai" +
                              "\ntertinggi tersebut" +
                              "\n\nMisal bilangan yang diinput  : 72 80 80 92 95 87 95" +
                              "\nNilai tertinggi              : 95" +
                              "\nJumlah                       : 2"
            });
            listExam.Add(new Exam
            {
                DaysNo = 3,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "Buatlah algoritma yang menentukan apakah sebuah bilangan prima" +
                              "\natau bukan. Bilangan diinputkan oleh user. Jika prima maka cetak" +
                              "\nperkataan 'Bil. Prima', jika ganjil maka cetak 'Bukan Bil. Prima'." +
                              "\nSusun algoritma pengecekan prima atau bukan prima ini."
            });
            listExam.Add(new Exam
            {
                DaysNo = 3,
                DaysDesc = "Days ",
                ExamNo = 3,
                ExamDesc = "Exam ",
                ExamDetails = "Di sebuah restoran, menjual makanan ayam bakar Rp.25.000/pc," + 
                              "\nayam goreng Rp.25.000/pc, pepes ikan bandeng Rp.23.000/pc" +
                              "\ndan ada minuman lemon tea Rp.15.000/pc, orange juice Rp.15.000/pc." +
                              "\nMakanan tersebut dapat diorder menggunakan aplikasi Ok-Jek dan" +
                              "\nmendapat diskon 30% dengan minimal order Rp.30.000 dan mendapat" +
                              "\ntambahan diskon ongkir 5% dari total harga setelah didiskon." +
                              "\n\nKeterangan : maksimal diskon adalah Rp.20.000 jika nama pembeli" +
                              "\nmengandung kata 'indah' atau 'bagus', diluar itu maksimal diskon" +
                              "\nRp.15.000 " +
                              "\n\nMisalkan : " +
                              "\n           Menu yang dibeli oleh Bagus Candra Ardinata" +
                              "\n           Makanan ke 1 = Rp. 25.000; Makanan ke 2 = Rp.23.000" +
                              "\n           Minuman ke 1 = Rp. 15.000" +
                              "\nOutput    : Harga yang harus dibayar 41895 "
            });
            listExam.Add(new Exam
            {
                DaysNo = 4,
                DaysDesc = "Days ",
                ExamNo = 1,
                ExamDesc = "Exam ",
                ExamDetails = "\n1. Menghitung jumlah hari bulan Jan, Mar, Jul, Sept, Nov" +
                              "\n2. Menghitung jumlah hari bulan Apr, Jun, Agst, Okt, Des" +
                              "\n\n output" +
                              "\nbulan Genap : 31 + 31 + 31 + 30 + 30 = 153" +
                              "\nbulan Ganjil : 30 + 30 + 31 + 31 + 31 = 153"
            });
            listExam.Add(new Exam
            {
                DaysNo = 4,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "\nuntuk menempuh jarak dari kota A ke kota B memerlukan waktu 210 menit" +
                              "\njika berangkat dari kota A pukul 05.45, pada pukul berapa " +
                              "\nsampai di kota B ?" 
            });
            listExam.Add(new Exam
            {
                DaysNo = 4,
                DaysDesc = "Days ",
                ExamNo = 3,
                ExamDesc = "Exam ",
                ExamDetails = "\nihsan pergi pukul 2.30 siang. ia baru kembali pukul 17.00" +
                              "\nberapa lama ihsan les ? "
            });
            listExam.Add(new Exam
            {
                DaysNo = 4,
                DaysDesc = "Days ",
                ExamNo = 4,
                ExamDesc = "Exam ",
                ExamDetails = "\nsaya pergi bekerja pukul 06.30 pagi dan pulang kerumah" +
                              "\npukul 17.00. berapa lama saya bekerja" 
            });
            listExam.Add(new Exam
            {
                DaysNo = 4,
                DaysDesc = "Days ",
                ExamNo = 5,
                ExamDesc = "Exam ",
                ExamDetails = "\npada 5,5 tahun yang lalu irma keponakan saya berumur 9 tahun." +
                              "\nBerapa umur Irma 36 bulan yang akan datang?"
            });
            listExam.Add(new Exam
            {
                DaysNo = 4,
                DaysDesc = "Days ",
                ExamNo = 6,
                ExamDesc = "Exam ",
                ExamDetails = "\nmenghapus duplikat nilai"
            });
            listExam.Add(new Exam
            {
                DaysNo = 5,
                DaysDesc = "Days ",
                ExamNo = 1,
                ExamDesc = "Exam ",
                ExamDetails = "\nbuatlah games sederhana, antara anda dengan komputer."+
                              "\nBerapa umur Irma 36 bulan yang akan datang?" +
                              "\npenilaiannya adalah angka milik siapa yang paling besar dengan range 0-9. " +
                              "\nrolenya adalah komputer jalan duluan dan angka yang didapat oleh komputer adalah random tanpa menampilkan angkanya." +
                              "\nuntuk tahap selanjutnya. anda akan diminta memasukkan angka." +
                              "\nsetelah itu akan muncul siapa pemenangnya dengan menampilkan perbandingan angkannya." +
                              "\n\nContoh : Masukkan angka anda    : 7" +
                              "\n           Angka Komputer         : 1" +
                              "\nSelamat anda menang / Anda telah kalah"
            });
            listExam.Add(new Exam
            {
                DaysNo = 5,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "\nSekelompok orang akan melakukan test drive Mobil Sport yang baru saja di launching." +
                              "\ndirute yang akan dilewati adalah dari diler di pondok indah ke lebak bulus " +
                              "\nsejauh 3.1 Km, dari lebak bulus ke bintaro plaza sejauh 5.3 Km lalu " +
                              "\ndari bintaro plaza ke X change bintaro adalah sejauh 1.9 Km." +
                              "\njika 1 liter bisa menempuh 8 Km," +
                              "\nberapa liter bensin yang dibutuhkan untuk sampai kembali ke titik awal." 
            });

            listExam.Add(new Exam
            {
                DaysNo = 6,
                DaysDesc = "Days ",
                ExamNo = 1,
                ExamDesc = "Exam ",
                ExamDetails = "\nSolve Me First"
            });
            listExam.Add(new Exam
            {
                DaysNo = 6,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimple Array Sum"
            });
            listExam.Add(new Exam
            {
                DaysNo = 6,
                DaysDesc = "Days ",
                ExamNo = 3,
                ExamDesc = "Exam ",
                ExamDetails = "\nCompare the Triplets"
            });
            listExam.Add(new Exam
            {
                DaysNo = 6,
                DaysDesc = "Days ",
                ExamNo = 4,
                ExamDesc = "Exam ",
                ExamDetails = "\nA Very Big Sum"
            });
            listExam.Add(new Exam
            {
                DaysNo = 6,
                DaysDesc = "Days ",
                ExamNo = 5,
                ExamDesc = "Exam ",
                ExamDetails = "\nDiagonal Difference"
            });
            listExam.Add(new Exam
            {
                DaysNo = 6,
                DaysDesc = "Days ",
                ExamNo = 6,
                ExamDesc = "Exam ",
                ExamDetails = "\nPlus Minus"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 1,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 1"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 2,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 2"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 3,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 3"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 4,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 4"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 5,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 5"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 6,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 6"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 7,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 7"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 8,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 8"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 9,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 9"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 10,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 10"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 11,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 5 cara 2"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 12,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 6 cara 2"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 13,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 6 cara 3"
            });
            listExam.Add(new Exam
            {
                DaysNo = 7,
                DaysDesc = "Days ",
                ExamNo = 14,
                ExamDesc = "Exam ",
                ExamDetails = "\nSimulasi 10 cara 2"
            });
            return listExam;
        }

        public static void GetListDays(List<Exam> paramListExams)
        {
            Console.WriteLine("\nList Days");

            int tempDays = new int();
            foreach (var item in paramListExams)
            {
                if (tempDays != item.DaysNo)
                {
                    Console.WriteLine("(" + item.DaysNo +") " + item.DaysDesc + item.DaysNo);
                    tempDays = item.DaysNo;
                }
            }
            Console.Write("Input number days : ");
        }

        public static void GetListExam(List<Exam> paramListExams, Int32 paramDay)
        {
            Console.WriteLine("\nList Exams");

            foreach (var item in paramListExams)
            {
                if (paramDay == item.DaysNo)
                {
                    Console.WriteLine("(" + item.ExamNo + ") " + item.ExamDesc + item.ExamNo);
                }
            }
            Console.Write("Input number exam : ");
        }

        public static void GetListExamDetails(List<Exam> paramListExams, Int32 paramDay, Int32 paramExam)
        {
            Console.WriteLine();
            //bool hasFound = false;

            foreach (var item in paramListExams)
            {
                if (paramDay == item.DaysNo && paramExam == item.ExamNo)
                {
                    Console.WriteLine("Exam No. " + item.ExamNo);
                    Console.WriteLine("Description : " + item.ExamDetails);
                }
            }
        }
    }

}
