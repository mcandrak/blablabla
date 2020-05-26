using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBatch218.Materi
{
    class Days6
    {

        #region from hackerrank

        public void Days6Exam1()
        {
            //Console.WriteLine("Solve Me First");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(a + " + " + b + " = " + sum);
        }

        public void Days6Exam2()
        {

            #region cara 1
            //Console.Write("\nMasukkan panjang array : ");
            //int arrSize = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nIsi array (a,b,c,..) : ");
            //string[] arrInp = Console.ReadLine().Split(',');

            //int[] arrNilai = new int[arrSize];
            //int total = 0;
            //for (int i = 0; i < arrSize; i++)
            //{
            //    string nilai = arrInp[i];
            //    arrNilai[i] = Convert.ToInt32(nilai);
            //    total += arrNilai[i];
            //}

            //Console.WriteLine("\n" + string.Join(" + ", arrNilai) + " = " + total);

            #endregion

            #region cara 2

            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            if (arr.Length > arCount)
            {
                Console.WriteLine("\n Angka yang ada masukkan melebihi range");
            }
            else
            {
                int result = Common.simpleArraySum(arr, arCount);
                Console.WriteLine(result);
            }
            #endregion
        }

        public void Days6Exam3()
        {
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp1 => Convert.ToInt32(arTemp1));
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp2 => Convert.ToInt32(arTemp2));
            int aScore = 0, bScore = 0;

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("\nMasukkan banyak angka yang sama pada masing-masing array!!");
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] > arr2[i])
                    {
                        aScore++;
                    }
                    if (arr1[i] < arr2[i])
                    {
                        bScore++;
                    }
                    if (arr1[i] == arr2[i])
                    {
                        aScore += 0;
                        bScore += 0;
                    }
                }
                Console.WriteLine(aScore + " " + bScore);
            }
        }

        public void Days6Exam4()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));

            long result = Common.aVeryBigSum(ar, arCount);

            Console.WriteLine(result);
        }

        public void Days6Exam5()
        {

        }

        public void Days6Exam6()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),
            arrTemp => Convert.ToInt32(arrTemp));

            Common.plusMinus(arr, n);
        }
        #endregion

        


    }
}
