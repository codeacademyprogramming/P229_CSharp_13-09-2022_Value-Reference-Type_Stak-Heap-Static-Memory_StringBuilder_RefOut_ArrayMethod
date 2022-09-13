using System;
using System.Text;
using System.Linq;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine(ReversedStr("Hello World P229")); //olleH dlroW 922P

            //int a = 5;

            //int b = a;

            //b += 10;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] arr1 = { 10, 20, 30 };
            //int[] arr2 = arr1;

            //int c = arr1[0];

            //arr2[0] = 100;

            //int[] arr3 = arr1;
            //arr3[0] = 400;

            //int[] arr4 = arr3;
            //arr4[0] = 900;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr3[0]);

            //ChangeIndexValue(arr3);

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr3[0]);

            //string str1 = "Hello";
            //string str2 = str1;
            //str2 += " Wordl";

            //Console.WriteLine(str1);
            //Console.WriteLine(str2);

            //int a;
            //Console.WriteLine(a);
            //ChangeValue(ref a);
            //ChangeValue(out int a);

            //Console.WriteLine(a);

            int[] arr = { 4, 5646, 45, 66,45,5654,53,45 };
            //Console.WriteLine(GetMaxValue(arr));
            //Console.WriteLine(Average(arr));

            //int maxNum = arr.Max();
            //Console.WriteLine(maxNum);
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Average());
            ////int firstIndex = Array.IndexOf(arr, 45);
            //Console.WriteLine(Array.IndexOf(arr,45, Array.IndexOf(arr, 45, Array.IndexOf(arr,45)+1) + 1));
            //Console.WriteLine(arr.Contains(45));
            //Console.WriteLine(arr.Sum());

            //Console.WriteLine("Before Sort");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("=================");
            //Array.Sort(arr);
            //Console.WriteLine("After Sort");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr);
            //Array.Reverse(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Reverse(arr, 3, 4);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arr.Length);
            //Array.Resize(ref arr, arr.Length+1);
            //arr[8] = 888;
            //Console.WriteLine(arr.Length);

            int[] newArr = new int[0];
            foreach (var item in arr)
            {
                if (item % 4 == 0)
                {
                    //int oldLength = newArr.Length;
                    //oldLength++;
                    //Array.Resize(ref newArr, oldLength);
                    //int lastIndex = newArr.Length - 1;
                    //newArr[lastIndex] = item;
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = item;
                }
            }

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }

        static double Average(int[] arr)
        {
            double sum = 0;

            foreach (int item in arr)
            {
                sum += item;
            }

            return sum / arr.Length;
        }

        static int GetMaxValue(int[] arr)
        {
            int max = 0;

            if (arr.Length > 0)
            {
                max = arr[0];

                foreach (int item in arr)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
            }

            return max;
        }

        static void ChangeValue(out int num)
        {
            num = 15;

        }

        static void ChangeIndexValue(int[] arr)
        {
            arr[0] = 500;
        }

        static string ReversedStr(string str)
        {
            StringBuilder reversed = new StringBuilder();
            //String str2 = new String("");
            Int32 b = new Int32();

            //string str1 = "";
            //int a = 5;
            for (int i = str.Length - 1; i >= 0 ; i--)
            {
                reversed.Append(str[i]);
            }

            return reversed.ToString();

            //string reversedStr = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    //char symbol = str[i];
            //    //reversedStr = reversedStr + symbol; //reversedStr += symbol

            //    reversedStr += str[i];
            //}

            //return reversedStr;
        }
    }
}
