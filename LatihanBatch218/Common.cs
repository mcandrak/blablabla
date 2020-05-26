using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218
{
    class Common
    {
        public static decimal FnHitungDiskon(decimal paramHarga, int paramDiskon)
        {
            return (paramHarga * paramDiskon) / 100;
        }

        public static string[] FnConvertStringToArray(string paramString, string paramSparator)
        {
            //variable tampung jumlah sparator
            int tempSparator = 1;
            for (int i = 0; i < paramString.Length; i++)
            {
                char a = (char)paramString[i];
                char b = Convert.ToChar(paramSparator);
                if (a == b)
                {
                    tempSparator++;
                }
            }
            /* declare variable string array */
            string[] strArray = new string[tempSparator];
            string kata = string.Empty;
            int indexStringArray = 0;
            for (int i = 0; i < paramString.Length; i++)
            {
                char a = (char)paramString[i];
                char cPemisah = Convert.ToChar(paramSparator); // ini spasi
                if (a == cPemisah)
                {
                    strArray[indexStringArray] = kata;
                    kata = string.Empty;
                    indexStringArray++;
                }
                else
                {
                    kata += paramString[i];
                }
                if (i == (paramString.Length - 1))
                {
                    strArray[indexStringArray] = kata;
                }
            }
            return strArray;
        }

        public static List<string> FnConvertStringToList(string paramString, string paramSeparator)
        {
            List<string> list = new List<string>();
            string kata = string.Empty;
            //merubah string ke char
            for (int i = 0; i < paramString.Length; i++)
            {
                char perKata = (char)paramString[i];
                char sparator = Convert.ToChar(paramSeparator);
                if (perKata == sparator)//membandingkan char dan separator
                {
                    list.Add(kata);
                    kata = string.Empty;
                }
                else if (i == (paramString.Length - 1))
                {
                    kata += perKata.ToString();
                    list.Add(kata);
                }
                else
                {
                    kata += perKata.ToString();
                }
            }
            return list;
        }

        public static double FnHitungBensin(double paramTotalJarak, double paramJarak1Liter)
        {
            return (paramTotalJarak / paramJarak1Liter) * 2;
        }

        public static int simpleArraySum(int[] ar, int count)
        {
            if (count > 0 && count <= 10000)
            {
                if (count == ar.Length)
                {
                    if (!ar.Any(item => (item < 0 || item >= 10000)))
                    {
                        return ar.Sum();
                    }
                }
            }
            return 0;
        }

        public static long aVeryBigSum(long[] ar, int count)
        {
            if (count > 0 && count <= 10)
            {
                if (count == ar.Length)
                {
                    if (!ar.Any(item => (item < 0 || item >= Math.Pow(10, 10))))
                    {
                        return ar.Sum();
                    }
                }
            }
            return 0;
        }

        public static void plusMinus(int[] arr, int count)
        {
            decimal pos = 0, zer = 0, neg = 0;

            if (count > 0 && count <= 100)
            {
                if (count == arr.Length)
                {
                    if (!arr.Any(item => (item < -100 || item > 100)))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if (arr[i] > 0)
                            {
                                pos++;
                            }
                            if (arr[i] == 0)
                            {
                                zer++;
                            }
                            if (arr[i] < 0)
                            {
                                neg++;
                            }
                        }
                        Console.WriteLine(pos / count);
                        Console.WriteLine(neg / count);
                        Console.WriteLine(zer / count);
                    }
                }
            }
        }

        public static void FnKonversi(int paramA)
        {
            double n;
            switch (paramA)
            {
                case 1:
                    Console.WriteLine("Konversi Galon ke Teko");
                    Console.Write("Masukkan Jumlah Galon : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Galon = {1} Teko", n, n * 6);
                    break;
                case 2:
                    Console.WriteLine("Konversi Galon ke Botol");
                    Console.Write("Masukkan Jumlah Galon : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Galon = {1} Botol", n, n * 18);
                    break;
                case 3:
                    Console.WriteLine("Konversi Galon ke Gelas");
                    Console.Write("Masukkan Jumlah Galon : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Galon = {1} Gelas", n, n * 45);
                    break;

                case 4:
                    Console.WriteLine("Konversi Teko ke Galon");
                    Console.Write("Masukkan Jumlah Teko : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Teko = {1} Galon", n, n / 6);
                    break;
                case 5:
                    Console.WriteLine("Konversi Teko ke Botol");
                    Console.Write("Masukkan Jumlah Teko : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Teko = {1} Botol", n, n * 3);
                    break;
                case 6:
                    Console.WriteLine("Konversi Teko ke Gelas");
                    Console.Write("Masukkan Jumlah Teko : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Teko = {1} Gelas", n, n * 7.5);
                    break;

                case 7:
                    Console.WriteLine("Konversi Botol ke Galon");
                    Console.Write("Masukkan Jumlah Botol : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Botol = {1} Galon", n, n / 18);
                    break;
                case 8:
                    Console.WriteLine("Konversi Botol ke Teko");
                    Console.Write("Masukkan Jumlah Botol : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Botol = {1} Teko", n, n / 3);
                    break;
                case 9:
                    Console.WriteLine("Konversi Botol ke Gelas");
                    Console.Write("Masukkan Jumlah Botol : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Botol = {1} Gelas", n, n * 2.5);
                    break;

                case 10:
                    Console.WriteLine("Konversi Gelas ke Galon");
                    Console.Write("Masukkan Jumlah Gelas : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Gelas = {1} Galon", n, Math.Round((n / 45),2));
                    break;
                case 11:
                    Console.WriteLine("Konversi Gelas ke Teko");
                    Console.Write("Masukkan Jumlah Gelas : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Gelas = {1} Teko", n, n / 7.5);
                    break;
                case 12:
                    Console.WriteLine("Konversi Gelas ke Botol");
                    Console.Write("Masukkan Jumlah Gelas : ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} Gelas = {1} Botol", n, n / 2.5);
                    break;

                default:
                    Console.WriteLine("pilihan yang dimasukkan tidak ada");
                    break;
            }
        }

        public static void FnRekursifSimulasi5(string kata, int paramA)
        {
            paramA++;
            string[] arrKata = kata.Split();
            
            int total = 0;
            for (int i = 0; i < kata.Length; i++)
            {
                total += Convert.ToInt32(kata[i].ToString());
            }

            Console.WriteLine("\nPenjumlahan Ke-{0} : {1} = {2}" , paramA, string.Join("+", arrKata), total);
            //Console.WriteLine("\nPenjumlahan Ke-"+ paramA + " : " + string.Join("+", arrKata) + " = " + total);

            string hasil = Convert.ToString(total);
            if (hasil.Length > 1)
            {
                Common.FnRekursifSimulasi5(hasil, paramA);
            }
        }

        public static void FnFactorial(int paramA)
        {
            for (int i = 2; i < paramA; i++)
            {
                if (paramA == i)
                {
                    Console.Write(i + "");
                }
                else if (paramA % i == 0)
                {
                    paramA = paramA / i;
                    Console.Write(i + " ");
                    Common.FnFactorial(paramA);
                }
            }
        }
    }
}
