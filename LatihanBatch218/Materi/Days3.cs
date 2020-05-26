using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days3
    {
        public void Days3Exam1()
        {
            while (true)
            {
                Console.Write("\nJawaban Exam 1 Day 3");
                Console.WriteLine("\n Mencari nilai maksimal : ");
                Console.Write(" Masukkan nilai : ");
                string input = Convert.ToString(Console.ReadLine());
                string[] inputArray = Common.FnConvertStringToArray(input, " ");


                if (inputArray.Length == 7)
                {
                    int[] arrayNilai = new int[inputArray.Length];
                    int max = 0;
                    int min = arrayNilai[0];

                    //convert string to int
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        string nilai = inputArray[i];
                        arrayNilai[i] = Convert.ToInt32(nilai);
                    }

                    //search max
                    for (int j = 0; j < inputArray.Length; j++)
                    {
                        if (max < arrayNilai[j])
                        {
                            max = arrayNilai[j];
                        }
                        else
                        {
                            if (min > arrayNilai[j])
                            {
                                min = arrayNilai[j];
                            }
                        }
                    }

                    //menghitung jumlah angka max
                    int jumlah = 0;
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        if (max == arrayNilai[k])
                        {
                            jumlah++;
                        }
                    }

                    #region mencari minimal
                    //mencari min
                    //int minimum = arrayNilai[0];
                    //for (int l = 0; l < inputArray.Length; l++)
                    //{
                    //    if (arrayNilai[l] < minimum)
                    //    {
                    //        minimum = arrayNilai[l];
                    //    }
                    //}
                    #endregion

                    Console.WriteLine("\n Bilangan maksimal : " + max);
                    Console.WriteLine("\n Jumlah : " + jumlah);
                    //Console.WriteLine("\n Bilangan minimal : " + minimum);
                    break;
                }
                else
                {
                    Console.WriteLine("\n Masukkan sebanyak 7 angka");
                }
            }
        }

        public void Days3Exam2()
        {
            Console.Write("\nJawaban Exam 2 Day 3");
            Console.Write("\n Masukkan angka : ");
            int angka = Convert.ToInt32(Console.ReadLine());
            bool prima = true;
            if (angka > 1)
            {
                for (int i = 2; i < angka; i++)
                {
                    if (angka % i == 0)
                    {
                        prima = false;
                        break;
                    }
                }
                if (prima)
                {
                    Console.WriteLine("\n Bilangan Prima");
                }
                else
                {
                    Console.WriteLine("\n Bukan Bilangan Prima");
                }
            }
            else
            {
                Console.Write("\n Bukan Bilangan Prima ");
            }

        }

        public void Days3Exam3()
        {
            Console.Write("\nJawaban Exam 3 Day 3");
            Console.Write("\n\n Masukkan nama pembeli : ");
            string nama = Console.ReadLine();
            string[] namaPembeli = Common.FnConvertStringToArray(nama.ToLower(), " ");

            #region makanan
            Console.WriteLine("\n====[ Menu Makanan ]====");
            List<Menu> menuMakanan = Menu.PopulateDataMakanan();

            /*proses mnampilkan menu makanan*/
            foreach (var item in menuMakanan)
            {
                Console.WriteLine("" + "(" + item.MenuId + ") " + item.MenuName + " " + item.Price);
            }

            /*mengambil inputan makanan dari console*/
            Console.Write("\n Order Makanan : ");
            string[] makanArray = Common.FnConvertStringToArray(Console.ReadLine(), ",");
            string[] arrayPsnMkn = new string[makanArray.Length];
            decimal totalHarga = 0; //variabel harga total

            /*menghitung harga total makanan yang di order*/
            for (int i = 0; i < makanArray.Length; i++)
            {
                foreach (var item in menuMakanan)
                {
                    decimal hargaItem = item.Price;
                    /*masukkan kondisi*/
                    if (Convert.ToInt32(makanArray[i]) == item.MenuId)
                    {
                        totalHarga += hargaItem;
                        arrayPsnMkn[i] = " Makanan ke " + (i + 1) + " " + item.MenuName + ": Rp." + item.Price;
                        break;
                    }
                }
            }
            #endregion

            #region minuman
            Console.WriteLine("\n====[ Menu Minuman ]====");
            List<Menu> menuMinuman = Menu.PopulateDataMinuman();

            /*proses menampilkan menu minuman*/
            foreach (var item in menuMinuman)
            {
                Console.WriteLine("" + "(" + item.MenuId + ") " + item.MenuName + " " + item.Price);
            }

            /*mengambil inputan minuman dari console*/
            Console.Write("\n Order Minuman : ");
            string[] minumArray = Common.FnConvertStringToArray(Console.ReadLine(), ",");
            string[] arrayPsnMnm = new string[minumArray.Length];

            /*menghitung harga total minuman yang di order*/
            for (int i = 0; i < minumArray.Length; i++)
            {
                foreach (var item in menuMinuman)
                {
                    decimal hargaItem = item.Price;
                    /*masukkan kondisi*/
                    if (Convert.ToInt32(minumArray[i]) == item.MenuId)
                    {
                        totalHarga += hargaItem;
                        arrayPsnMnm[i] = " Minuman ke " + (i + 1) + " " + item.MenuName + ": Rp." + item.Price;
                        break;
                    }
                }
            }
            //Console.WriteLine("\n Total Pembayaran : Rp." + totalHarga);
            #endregion

            Console.Write("\n Pesan pakai Ok-Jek (Y/N)? ");
            string jawab = Console.ReadLine().ToLower();
            decimal potonganHarga = 0;
            if (jawab == "y")
            {
                if (totalHarga >= 30000)
                {
                    potonganHarga = totalHarga * 30 / 100;
                    if (potonganHarga > 15000 || potonganHarga > 20000)
                    {
                        for (int j = 0; j < namaPembeli.Length; j++)
                        {
                            if (namaPembeli[j] == "indah" || namaPembeli[j] == "bagus")
                            {
                                potonganHarga = 20000;
                                break;
                            }
                            else
                            {
                                potonganHarga = 15000;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\n Menu yang dibeli oleh " + nama);
            Console.WriteLine("\n\n" + string.Join("\n", arrayPsnMkn));
            Console.WriteLine("\n" + string.Join("\n", arrayPsnMnm));
            Console.WriteLine();
            Console.WriteLine(" Total Pembayaran        : Rp." + totalHarga);

            totalHarga = totalHarga - potonganHarga;
            decimal potonganOngkir = totalHarga * 5 / 100;

            Console.WriteLine(" Diskon Ok-Jek           : Rp." + potonganHarga);
            Console.WriteLine("                         ______________-");
            Console.WriteLine(" Total Pembayaran        : Rp." + totalHarga);

            decimal bayarFinal = totalHarga - potonganOngkir;

            Console.WriteLine(" Diskon ongkir 5%        : Rp." + potonganOngkir);
            Console.WriteLine("                         ______________-");
            Console.WriteLine(" Total Pembayaran akhir  : Rp." + bayarFinal);
        }
    }

    public class Menu
    {
        public Int32 MenuId { get; set; }

        public string MenuName { get; set; }

        public decimal Price { get; set; }

        public static List<Menu> PopulateDataMakanan()
        {
            List<Menu> listMakanan = new List<Menu>();
            listMakanan.Add(new Menu
            {
                MenuId = 1,
                MenuName = "Ayam Bakar",
                Price = Convert.ToDecimal(25000.00)

            });
            listMakanan.Add(new Menu
            {
                MenuId = 2,
                MenuName = "Ayam Goreng",
                Price = Convert.ToDecimal(25000.00)

            });
            listMakanan.Add(new Menu
            {
                MenuId = 3,
                MenuName = "Pepes Ikan Bandeng",
                Price = Convert.ToDecimal(23000.00)

            });
            return listMakanan;
        }

        public static List<Menu> PopulateDataMinuman()
        {
            List<Menu> listMinuman = new List<Menu>();
            listMinuman.Add(new Menu
            {
                MenuId = 1,
                MenuName = "Lemon Ice",
                Price = Convert.ToDecimal(15000.00)

            });
            listMinuman.Add(new Menu
            {
                MenuId = 2,
                MenuName = "Orange Juice",
                Price = Convert.ToDecimal(15000.00)

            });
            return listMinuman;
        }
    }
}
