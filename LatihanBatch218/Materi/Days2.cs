using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days2
    {
        public void Days2Exam1()
        {
            Console.Write("\nJawaban Exam 1 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            string outp = string.Empty;
            string[] arrayKalimat = inp.Split(' ');
            /* looping sejumlah data di array*/
            foreach (var item in arrayKalimat)
            {
                string kata = string.Empty;
                /* looping sejumlah kata dimasing masing isian array*/
                for (int i = 0; i < item.Length; i++)
                {
                    //Console.WriteLine(item[i]);
                    if (i == 0 || i == item.Length - 1)
                    {
                        kata += item[i];
                    }
                    else
                    {
                        kata += "*";
                    }
                }
                arrayKalimat[Array.IndexOf(arrayKalimat, item)] = kata;
            }
            Console.WriteLine("\nOutput: " + string.Join(" ", arrayKalimat));
        }

        public void Days2Exam2()
        {
            Console.Write("\nJawaban Exam 2 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string kata = Console.ReadLine();
            int jmlKata = 0;
            bool result;
            for (int i = 0; i < kata.Length; i++)
            {
                char a = (char)kata[i];
                result = Char.IsUpper(a);
                if (result == true)
                {
                    jmlKata++;
                }
            }
            Console.WriteLine("\nOutput: " + jmlKata);
        } 

        public void Days2Exam3()
        {
            Console.Write("\nJawaban Exam 3 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            string[] arrayKalimat3 = inp.Split(' ');
            /* looping sejumlah data di array*/
            foreach (var item in arrayKalimat3)
            {
                string kata3 = string.Empty;
                /* looping sejumlah kata dimasing masing isian array*/
                for (int i = 0; i < item.Length; i++)
                {
                    //Console.WriteLine(item[i]);
                    if (i == 0)
                    {
                        kata3 += Convert.ToString(item[i]).ToUpper();
                    }
                    else
                    {
                        kata3 += "*";
                    }
                }
                arrayKalimat3[Array.IndexOf(arrayKalimat3, item)] = kata3;
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayKalimat3));
        }

        public void Days2Exam4()
        {
            Console.Write("\nJawaban Exam 4 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            string[] arrayKalimat4 = inp.Split(' ');
            /* looping sejumlah data di array*/
            foreach (var item in arrayKalimat4)
            {
                string kata4 = string.Empty;
                /* looping sejumlah kata dimasing masing isian array*/
                for (int i = 0; i < item.Length; i++)
                {
                    //Console.WriteLine(item[i]);
                    if (i == item.Length - 1)
                    {
                        kata4 += Convert.ToString(item[i]).ToUpper();
                    }
                    else
                    {
                        kata4 += "*";
                    }
                }
                arrayKalimat4[Array.IndexOf(arrayKalimat4, item)] = kata4;
            }
            Console.WriteLine("\nOutput : " + string.Join(" ", arrayKalimat4));
        }

        public void Days2Exam5()
        {
            Console.Write("\nJawaban Exam 5 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();

            #region cara 1
            string[] arrayKalimat = inp.Split(' ');
            /* looping sejumlah data di array*/
            foreach (var item in arrayKalimat)
            {
                string kata5 = string.Empty;
                kata5 = Convert.ToString(item[2]).ToUpper();
                arrayKalimat[Array.IndexOf(arrayKalimat, item)] = kata5 + "***";
            }
            Console.WriteLine("\nOutput: " + string.Join(" ", arrayKalimat));
            #endregion

            #region cara 2
            //string[] arrayKalimat = inp.Split(' ');
            ///* looping sejumlah data di array*/
            //for (int i = 0; i < arrayKalimat.Length; i++)
            //{
            //    if (arrayKalimat[i].Length >= 3)
            //    {
            //        string kata = arrayKalimat[i][2].ToString().ToUpper();
            //        arrayKalimat[i] = kata + "***";
            //    }
            //}
            //Console.WriteLine("\nOutput: " + string.Join(" ", arrayKalimat));
            #endregion
        }

        public void Days2Exam6()
        {
            Console.Write("\nJawaban Exam 6 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            string[] arrayKalimat = inp.Split(' ');

            #region cara 1
            /* looping sejumlah data di array*/
            foreach (var item in arrayKalimat)
            {
                string kata6 = string.Empty;
                /* looping sejumlah kata dimasing masing isian array*/
                for (int i = 2; i < item.Length; i++)
                {
                    kata6 += item[i].ToString().ToUpper();
                }
                arrayKalimat[Array.IndexOf(arrayKalimat, item)] = kata6;
            }
            Console.WriteLine("\nSoal 6 : " + string.Join(" ", arrayKalimat));
            #endregion

            #region cara 2
            //string[] strArray = inp.Split(' ');
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    if (strArray[i].Length >= 3)
            //    {
            //        string kata = string.Empty;
            //        for (int j = 2; j < strArray[i].Length; j++)
            //        {
            //            kata += strArray[i][j].ToString().ToUpper();
            //        }
            //        strArray[i] = kata;
            //    }
            //    else
            //    {
            //        strArray[i] = "";
            //    }
            //}
            //Console.WriteLine("\nSoal 6 cara 2 : " + string.Join(" ", strArray));
            #endregion
        }

        public void Days2Exam7()
        {
            Console.Write("\nJawaban Exam 7 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            int jmlKata = 0;
            for (int i = 0; i < inp.Length; i++)
            {
                char a = (char)inp[i];
                if (a == '.')
                {
                    jmlKata++;
                }
            }
            Console.WriteLine("\nSoal 7 : " + jmlKata);

        }

        public void Days2Exam8()
        {
            Console.Write("\nJawaban Exam 8 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            int temp;
            char[] arr1;
            arr1 = inp.ToCharArray();
            int k = arr1.Length - 1;
            temp = k;
            Console.Write("\nSoal 8 : ");
            for (int i = k; temp >= 0; k--)
            {
                Console.Write(arr1[temp] + "" + ' ');
                --temp;
            }
        }

        public void Days2Exam9()
        {
            #region algoritma
            /*
             SOAL
             input "Kata"
             output "aakt"
             ALGORITMA
             1. deklarasi array string dari input
             2. convert string array ke char array
             3. proses sort
             4. conver lagi dari char array ke string
             5. cetak
             */
            #endregion

            Console.Write("\nJawaban Exam 9 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");

            #region cara 1
            //string inp = Console.ReadLine();
            //string[] arrayKalimat = inp.ToLower().Split(' ');
            ///* looping sejumlah data di array*/
            //Console.Write("\nOutput : ");
            //foreach (var item in arrayKalimat)
            //{
            //    string str = item;
            //    char[] arr1;
            //    char ch;
            //    arr1 = str.ToCharArray();
            //    for (int i = 1; i < arr1.Length; i++)
            //        for (int j = 0; j < arr1.Length - i; j++)
            //            if (arr1[j] > arr1[j + 1])
            //            {
            //                ch = arr1[j];
            //                arr1[j] = arr1[j + 1];
            //                arr1[j + 1] = ch;
            //            }
            //    foreach (char c in arr1)
            //    {
            //        ch = c;
            //        Console.Write("{0} ", ch);
            //    }
            //    Console.Write(" ");
            //}

            #endregion

            #region cara 2
            //string inp = Console.ReadLine();
            //string[] words = inp.ToLower().Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{
            //    char[] letters = words[i].ToCharArray();
            //    for (int j = 0; j < letters.Length; j++)
            //    {
            //        int pointer = j;
            //        for (int k = j; k < letters.Length; k++)
            //        {
            //            if (letters[pointer] > letters[k])
            //            {
            //                pointer = k;
            //            }
            //        }
            //        char swap = letters[pointer];
            //        letters[pointer] = letters[j];
            //        letters[j] = swap;
            //    }
            //    words[i] = string.Join("", letters);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Output" + string.Join(" ", words));
            #endregion

            #region cara 3
            string input = Console.ReadLine().ToLower();

            /*2. convert string input jadi string array*/
            /*a. split otomatis*/
            //string[] inputArray = input.Split(' ');
            /*b split manual*/
            string[] inputArray = Common.FnConvertStringToArray(input, " ");

            //3. convert string array jadi char array
            for (int i = 0; i < inputArray.Length; i++)
            {
                string kata = inputArray[i];
                char[] inputChar = new char[kata.Length];

                //convert karakter to char
                for (int j = 0; j < inputChar.Length; j++)
                {
                    char a = (char)kata[j];
                    inputChar[j] = a;
                }

                //4. proses sorting char array
                char t;
                for (int p = 0; p < inputChar.Length - 2; p++)
                {
                    for (int k = 0; k < inputChar.Length - 1; k++)
                    {
                        char a1 = inputChar[k];
                        char a2 = inputChar[k + 1];

                        if (a1 > a2)
                        {
                            t = a2;
                            inputChar[k + 1] = a1;
                            inputChar[k] = t;
                        }
                    }
                }
                //proses mengembalikan char ke string
                kata = string.Empty; //mengosongkan variabel kata
                for (int l = 0; l < inputChar.Length; l++)
                {
                    kata += inputChar[l].ToString();
                }
                //proses update string array
                inputArray[i] = kata;
            }

            Console.WriteLine("\nOutput : " + string.Join(" ", inputArray));
            #endregion
        }

        public void Days2Exam10()
        {
            Console.Write("\nJawaban Exam 10 Day 2");
            Console.Write("\nMasukkan Kalimat   : ");
            string inp = Console.ReadLine();
            string[] arrayKalimat = inp.Split(' ');
            /* looping sejumlah data di array*/
            for (int i = 0; i < arrayKalimat.Length; i++)
            {
                if (arrayKalimat[i].Length >= 3)
                {
                    string kata = arrayKalimat[i][0].ToString().ToLower();
                    string kata2 = arrayKalimat[i][arrayKalimat[i].Length-1].ToString().ToLower();
                    arrayKalimat[i] = kata + "***" + kata2;
                }
            }
            Console.WriteLine("\nOutput: " + string.Join(" ", arrayKalimat));
        }
    }
}
