using Azure.Core.GeoJson;
using DesignProject.DesignPatterns.Behavior.Command;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignProject.Algo
{
    public class Common
    {
        public void GetFibonicciSeries(int n)
        {


            int first = 0;
            int second = 1;
            int count = 2;
            Console.Write($"{first} {second}");

            //   0,1,1,2,3

            while (count < n)
            {
                int temp = second;
                second = first + second;
                first = temp;

                count++;

                Console.WriteLine(" " + second);
            }
        }

        public void GetNthFibonicciNumber(int n)
        {

            int first = 0;
            int second = 1;
            int count = 2;

            while (count <= n)
            {
                int temp = second;
                second = first + second;
                first = temp;

                count++;
            }

            Console.WriteLine($"{second}");


        }

        public void SwapWithoutTemp(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a}{b}");
        }


        public void RotateArray(int position)
        {
            // by 4 places
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //   
            //   


            reverse(arr1, 0, arr1.Length - 1);

            //reverse(arr1, 0, position - 1);

            //reverse(arr1, position, arr1.Length - 1);

            reverse(arr1, arr1.Length - position, arr1.Length - 1);

            reverse(arr1, 0, arr1.Length - position - 1);

        }

        public int[] reverse(int[] arr, int start, int end)
        {

            while (start < end)
            {
                (arr[start], arr[end]) = (arr[end], arr[start]);
                start++; end--;
            }
            return arr;
        }



        public int[] ReverseWithDiff()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int start = 0;
            int end = arr.Length - 1;

            int temp = 0;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;


                start++;
                end--;
            }

            return arr;
        }


        public void CountOccurence(int number, int data)
        {
            // 13839 / 10 = 1383

            int count = 0;

            while (data != 0)
            {
                int n = data % 10;


                count++;
                data = data / 10;
            }

            Console.WriteLine(count);
        }

        public void ReverseNumber(int number)
        {
            int n = 0;
            // 13839
            while (number > 0)
            {
                n = n * 10 + number % 10; // 93
                number = number / 10;
            }

            Console.WriteLine(n);
        }

        public void Array2Dimensional()
        {                                  //0           //1
            int[,] secondDimensional = { { 1, 2, 3}
                                        , { 1, 2,3} };

            for (int i = secondDimensional.GetLength(0) - 1; i > 0; i--)
            {
                for (int j = 0; j < secondDimensional.GetLength(1); j++)
                {
                    Console.Write(" " + secondDimensional[i, j]);
                }
                Console.WriteLine();

            }

        }



        public void Reverse2DArray(int[,] arr)
        {
            for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(" " + arr[i, j]);
                }

                Console.WriteLine();

            }
            ArrayList arrs = new ArrayList() { "1", 1, 2, 3, "sdgsd" };

        }

        public void Reverse3DArray()
        {

            int[,,] arr = new int[,,]
            {
                {
                   {1,2,3,4 }
                },
                {
                   {5,6,7,8 }
                }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[arr.GetLength(0) - i - 1, arr.GetLength(1) - 1 - j, arr.GetLength(2) - 1 - k]); ;
                    }
                }
            }



        }

        public void JaggedArray()
        {
            int[][][] jaggedArray = { new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 6, 7 } }, new int[][] { new int[] { 1, 2, 3, 5 } } };


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (int k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        Console.Write(" " + jaggedArray[i][j][k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void FindMax(int[] arr)
        {
            int max = 0;

            foreach (var item in arr)
            {
                max = item > max ? item : max;
            }

            Console.WriteLine("Max value is" + max);
        }

        public void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                (arr[start], arr[end]) = (arr[end], arr[start]);
                start++;
                end--;
            }
        }


        public void ReverseArrayWithDiffTeq()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int start = arr[0];
            int end = arr[arr.Length - 1];

            while (start < end)
            {
                int temp = end;
                end = start;
                start = temp;
                start++;
                end--;
            }

        }

        public void CountEvenIntegers()
        {
            int[] arr = new int[] { 12, 45, 456, 23 };
            int count = 1;
            int cnt = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                while (arr[i] != 0)
                {
                    arr[i] = arr[i] / 10;
                    count++;
                }

                if (count % 2 == 0)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }

        public void FindMaxSumIn2DArray()
        {
            int[,] elements = new int[,] { { 1, 2, 3, 5 }, { 4, 3, 3, 2 } };

            int max = 0;
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    sum += elements[i, j];
                }

                if (sum > max)
                {
                    max = sum;
                }
            }

            Console.WriteLine(max);
        }

        public void BinarySearch(int number)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int start = 0;
            int end = sortedArray.Length - 1;
            int mid = (start + end) / 2;


            while (start <= end)
            {
                mid = (start + end) / 2;

                if (sortedArray[mid] < number)
                {
                    start = mid + 1;
                }
                else if (sortedArray[mid] > number)
                {
                    end = mid - 1;
                }
                else
                {
                    Console.WriteLine(mid);
                    return;
                }

            }

            return;

        }


        public void FindAnagrams(string str1, string str2)
        {

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not anagrams");
                return;
            }

            Dictionary<char, int> dict1 = new Dictionary<char, int>();

            foreach (var items in str1)
            {
                if (dict1.ContainsKey(items))
                {
                    dict1[items]++;
                }
                else
                {
                    dict1[items] = 1;
                }
            }


            foreach (var items in str2)
            {
                if (!dict1.ContainsKey(items) || dict1[items] == 0)
                {
                    Console.WriteLine("Not anagrams");
                    return;
                }

                dict1[items]--;
            }


            Console.WriteLine("Anagrams");
            return;

        }



        public int OrderAgnoisticBinary(int number, int[] sortedArray, int start, int end)
        {

            if (sortedArray[start] < sortedArray[end])
            {
                while (start <= end)
                {
                    int mid = start + end - start / 2;

                    if (sortedArray[mid] > number)
                    {
                        end = mid - 1;
                    }
                    else if (sortedArray[mid] < number)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        Console.WriteLine(mid);
                        return mid;
                    }
                }

            }
            else if (sortedArray[start] > sortedArray[end])
            {

                while (start <= end)
                {
                    int mid = (start + end) / 2;

                    if (sortedArray[mid] > number)
                    {
                        start = mid + 1;
                    }
                    else if (sortedArray[mid] < number)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        Console.WriteLine(mid);
                        return mid;
                    }
                }
            }

            return -1;
        }

        public void FindCielingOrFloor(int number, bool FindFloor)
        {                         //     0,1,2,3,4,5,6,7,8
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 7, 8, 9 };



            int start = 0;
            int end = sortedArray.Length - 1;

            while (start <= end)
            {
                int mid = start + end - start / 2;

                if (sortedArray[mid] > number)
                {
                    end = mid - 1;
                }
                else if (sortedArray[mid] < number)
                {
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine(mid);
                    return;
                }
            }

            if (FindFloor)
            {
                Console.WriteLine(end);
                return;
            }
            Console.WriteLine(start);
            return;

        }


        public void FindInMountainArray(int number)
        {
            int[] sortedArray = new int[] { 5, 6, 7, 8, 9, 10, 4, 3, 2, 1 };

            var peak = FindPeakIndex(sortedArray);

            var firstTry = OrderAgnoisticBinary(number, sortedArray, 0, peak);

            if (firstTry < 0)
            {
                firstTry = OrderAgnoisticBinary(number, sortedArray, peak + 1, sortedArray.Length - 1);
            }

            Console.WriteLine(firstTry);
        }

        // 1,2,3,4,5,6,5,4,3,2,1

        public int FindPeakIndex(int[] sortedArray)
        {
            int start = 0;
            int end = sortedArray.Length - 1;

            while (start < end)
            {
                int mid = (start + end) / 2;

                if (sortedArray[mid] > sortedArray[mid + 1])
                {
                    // It might be possible that the answer lies here only
                    end = mid;
                    // 1,2,3,4,5,6,7
                    //7,2,3,4,5,6,1
                    //6,7,3,4,5,1,2
                    //5,6,7,3,4,1,2,3
                    // 3,4,5,6,7,1,2

                    //2,9,2,2,2
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;

        }


        public void getdata(ref int dd)
        {

        }

        public class A
        {

        }


        public class B : A
        {

        }
        public void FindCielingOrFloorOfCharacter(char character, bool findFloor)
        {
            List<string> A = new List<string>();

            A[0] = "ss";

            char[] sortedArray = new char[] { 'a', 'b', 'c' };

            int start = 0;
            int end = sortedArray.Length - 1;

            while (start <= end)
            {
                int mid = start + end - start / 2;

                if (sortedArray[mid] > character)
                {
                    end = mid - 1;

                }
                else
                {
                    start = mid + 1;
                }
            }

            if (findFloor)
            {

                Console.WriteLine(sortedArray[end % sortedArray.Length]);
            }
            else
            {
                Console.WriteLine(sortedArray[start % sortedArray.Length]);
            }

        }

        public int[] FindFirstandLast()
        {
            return new int[] { FindFirstAndLastOccurrence(4, true), FindFirstAndLastOccurrence(4, false) };
        }

        public int FindFirstAndLastOccurrence(int number, bool findStartIndex)
        {
            int[] sortedArray = new int[] { 1, 1, 1, 4, 4, 4, 5, 5, 5 };

            int start = 0;
            int end = sortedArray.Length - 1;
            int ans = 0;
            while (start <= end)
            {
                int mid = start + end / 2;

                if (sortedArray[mid] > number)
                {
                    end = mid - 1;
                }
                else if (sortedArray[mid] < number)
                {
                    start = mid + 1;
                }
                else
                {
                    ans = mid;

                    if (findStartIndex)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }

            return ans;
        }

        public void FindInInfiniteArray(int number)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int start = 0;
            int end = 1;

            while (sortedArray[end] < number)
            {
                start = end + 1;
                end = end - start + 1;
            }

            Console.WriteLine(BinarySearch(start, end, sortedArray, number));
        }

        public int BinarySearch(int start, int end, int[] arr, int number)
        {
            while (start <= end)
            {
                int mid = start + end - start / 2;
                if (arr[mid] > number)
                {
                    end = end - 1;
                }
                else if (arr[mid] < 1)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }

            }

            return -1;
        }

        public void FindPeakInCircularArray()
        {
            // 1,2,3,4,5,6,7
            // 7,2,3,4,5,6,1
            // 6,7,3,4,5,1,2
            // 5,6,7,4,1,2,3
            int[] sortedArray = new int[] { 5, 6, 7, 8, 9, 10, 11, 1, 2, 3, 4 };

            var peak = FindPeakIncircularArray(sortedArray);
        }

        public void FindPeakDuplicateCircularArray()
        {
            int[] sortedArray = new int[] { 5, 5, 5, 6, 6, 6, 7, 8, 1, 1, 2, 2, 3, 3, 3, 4, 4, 5, 5 };

            int start = 0;
            int end = sortedArray.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (mid < end && sortedArray[mid] > sortedArray[mid + 1])
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (mid > start && sortedArray[mid - 1] > sortedArray[mid])
                {
                    Console.WriteLine(mid - 1);
                    return;
                }
                else if (sortedArray[mid] == sortedArray[start] && sortedArray[mid] == sortedArray[end])
                {
                    if (sortedArray[end - 1] > sortedArray[end])
                    {
                        Console.WriteLine(end - 1);
                    }
                    end--;

                    if (sortedArray[start] > sortedArray[start + 1])
                    {
                        Console.WriteLine(start);
                    }
                    start++;
                }
                else if (sortedArray[mid] < sortedArray[start] || sortedArray[mid] == sortedArray[start] && sortedArray[end] > sortedArray[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return;
        }

        public int FindPeakIncircularArray(int[] sortedArray)
        {

            //5, 6, 7, 8, 9, 10, 11, 1, 2, 3, 4 

            int start = 0;
            int end = sortedArray.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (sortedArray[mid] > sortedArray[mid + 1])
                {
                    return mid;
                }
                else if (sortedArray[mid] < sortedArray[mid - 1])
                {
                    return mid - 1;
                }
                else if (sortedArray[start] > sortedArray[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            return -1;

        }


        // 1,2,4,8
        // 8,16,32,64

        public void FindIn2DArrayBinarySearch(int target)
        {
            int[][] matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 5, 6, 7 }, new int[] { 8, 9, 10 } };

            int row = 0;
            int column = matrix.Length - 1;

            while (row < matrix.Length && column >= 0)
            {

                // 1,2,3
                // 5,6,7
                // 8,9,10

                if (matrix[row][column] == target)
                {
                    Console.WriteLine($"{row} {column}");
                    return;
                }
                if (matrix[row][column] < target)
                {
                    row++;
                }
                else
                {
                    column--;
                }

            }
            return;
        }


        public void BubbleSort()
        {
            int[] arr = new int[] { 4, 5, 3, 2, 6, 8, 1 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = 0;
                        temp = arr[j + 1];
                        arr[j + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

        }


        public void SelectionSort()
        {
            int[] arr = new int[] { 2, 3, 4, 5, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                int last = arr.Length - i - 1;

                arr = GetMaxArray(arr, last, i);

            }
        }

        public void InsertionSort()
        {
            int[] arr = new int[] { 5, 4, 2, 3, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                    else
                    {
                        break;
                    }
                }
            }
        }


        public int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
            int mid = arr.Length / 2;

            int[] left = MergeSort(arr[0..mid]);   // Sort left half
            int[] right = MergeSort(arr[mid..arr.Length]);  // Sort right half

            return Merge(left, right);   // Merge sorted halves

        }

        int[] Merge(int[] left, int[] right)
        {
            int[] mix = new int[left.Length + right.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while(i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    mix[k] = left[i];
                    i++;
                }
                else
                {
                    mix[k] = right[j];
                    j++;
                }

                k++;


            }

            while(i < left.Length)
            {
                mix[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                mix[k] = right[j];
                j++;
                k++;
            }

            return mix;

        }

        public int[] GetMaxArray(int[] arr, int end, int start)
        {
            int max = start;
            for (int i = 0; i < end; i++)
            { 
              max = arr[max] < arr[i] ? i : max;  
            }

            (arr[end], arr[max]) = (arr[max], arr[end]);

            return arr;
        }

        public void CyclicSort()
        {                          // 1 2 3 4 5
            int[] arr = new int[] { 3, 4, 2, 1, 5 };

            int i = 0;

            while (i < arr.Length)
            {
                int correct = arr[i] - 1;

                if (arr[i] != arr[correct])
                {
                    int temp = arr[i];
                    arr[i] = arr[correct];
                    arr[correct] = temp;
                }
                else
                {
                    i++;
                }
            }

            foreach (var items in arr)
            {

                Console.WriteLine(items);
            }
        }

        public void CreatePatterns()
        {
            int n = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            int variable = 1;

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {

                    Console.Write(" " + variable);

                    if (j < 3)
                    {
                        variable *= 2;
                    }

                }

                Console.WriteLine();
            }



            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();

            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 5 - i; k++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }


            for (int i = 1; i <= 2 * n; i++)
            {
                for (int j = 1; j <= (i < n ? n - i : i - n); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (i < n ? i : 2 * n - i); k++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    var min = Math.Min(Math.Min(i, j), Math.Min(4 - i, 4 - j));

                    Console.Write(min);
                }
                Console.WriteLine();
            }
        }

        public int PrintFibo(int n)
        {
            if (n <= 1)
                return n;
            else
                return PrintFibo(n - 1) + PrintFibo(n - 2);
        }

        public int RecursiveBinarySearch(int target, int start, int end, int[] arr)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = (start + end) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] > target)
            {
                return RecursiveBinarySearch(target, start, mid - 1, arr);
            }

            return RecursiveBinarySearch(target, mid + 1, end, arr);

        }


        public void findDuplicates()
        {
            int[] arr = new int[] { 1, 2, 3, 3, 5, 6, 7, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        Console.Write(arr[i] + " " + count);
                    }
                }
            }
        }



        public void DifferentwaysForDuplicates()
        {

            //Using Linq
            int[] array = { 1, 2, 3, 4, 5, 3, 2, 6 };
            var duplicates = array.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key)
                                  ;

            Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));

            HashSet<int> set = new HashSet<int>();

            List<int> duplicate = new List<int>();

            foreach (int x in array)
            {
                if (!set.Add(x))
                    duplicate.Add(x);
            }

            Console.WriteLine("Duplicates: " + string.Join(", ", duplicate));


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicate.Add(array[i]);

                    }
                }
            }
            Console.WriteLine("Duplicates: " + string.Join(", ", duplicate));


            Dictionary<int, int> dup = new Dictionary<int, int>();

            foreach (int x in array)
            {
                if (dup.ContainsKey(x))
                {
                    dup[x]++;
                }
                else
                {
                    dup[x] = 1;
                }
            }

            var dupin = array.Except(array.Distinct());



            List<string> list1 = new List<string>() { "Avinash", "ST" };

            List<string> list2 = new List<string>() { "Avinash", "ST", "DBB" };


        }




        public void FindDistinctandDuplicates()
        {
            int[] arr = new int[] { 1, 2, 3, 3, 4, 5, 5 };


            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Count occurrences of each element
            foreach (int num in arr)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

        }


        public int[] GetDistinct(int[] arr)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    result.Add(arr[i]);
                }
            }

            return result.ToArray();
        }
            public static string ShiftCharacters(string word, int n)
        {
            string shiftedWord = "";
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    int shift = n % 26; // Handle shift for alphabets
                    char newChar = (char)((char.ToLower(c) - 'a' + shift) % 26 + 'a');
                    if (char.IsUpper(c))
                    {
                        newChar = char.ToUpper(newChar);
                    }
                    shiftedWord += newChar;
                }
                else
                {
                    shiftedWord += c; // Non-alphabetic characters remain unchanged
                }
            }
            return shiftedWord;
        }


        public void DistinctByandExceptBy()
        {
            List<object> obj = new List<object>()
             {
                 new{ test1 = 1, test2 ="Avinash"}
             };

            List<object> obj2 = new List<object>()
             {
                 new{ test1 = 1, test2 ="Avinash", test3 = "A::::"},
                 new{ test1 = 2, test2 ="Avinash",test3 = "A::::"},
                 new{ test1 = 2, test2 ="Avinash2",test3 = "A::::"}
             };


            var distdict = obj2.DistinctBy(x => x.GetType().GetProperty("test3"));
            var details = obj2.ExceptBy(obj.Select(x => x.GetType()?.GetProperty("test1")?.GetValue(x)), x => x.GetType().GetProperty("test1")?.GetValue(x));

            foreach (var items in distdict)
            {
                Console.WriteLine(items.GetType()?.GetProperty("test1")?.GetValue(items));
            }
        }


        public bool CheckPrime(int n)
        {
            int i = 2;

            if (n <= 1)
            {

                return false;
            }

            while (i * i <= n)
            {

                if (n % i == 0)
                {
                    return false;
                }

            }

            return true;
        }

        public void GiveListPrime(int n)
        {

            bool[] primeList = new bool[n + 1];

            for (int i = 2; i * i <= n; i++)
            {

                for (int j = i * 2; j <= n; j += i)
                {
                    if (!primeList[j])
                    {
                        primeList[j] = true;
                    }
                }



            }

            for (int i = 2; i < primeList.Length; i++)
            {
                if (!primeList[i])
                    Console.WriteLine(i);
            }
        }

        public void SquareRoot(int n, int p)
        {
            int start = 0;
            int end = n;
            int mid = 0;
            while (start <= end)
            {
                mid = start + (end - start) / 2;


                if (mid * mid == n)
                {
                    Console.WriteLine(mid);
                    return;
                }

                if (mid * mid > n)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }




            double incr = 0.1f;

            double root = start;
            for (int i = 0; i < p; i++)
            {
                while (root * root <= n)
                {
                    root += incr;
                }

                root -= incr;
            }

            Console.WriteLine(root);
        }



        public void findDataInGivenArray()
        {
            int[] arr1 = new int[] { 1, 3, 5, 6, };

            int[] arr2 = new int[] { 8, 4, 5, 6, 2 };

            if (arr1.Sum() > arr2.Sum())
            {
                Console.WriteLine("-1");
                return;
            }

            int ndstart = 0;

            var listArr = arr1.ToList();

            int start = 0;
            int end = arr1.Length - 1;


            ArraySegment<int> arr4 = new ArraySegment<int>(arr1, 0, arr1.Length - 4);
            ArraySegment<int> arr5 = new ArraySegment<int>(arr1, 0, arr1.Length - 4);



            while (start < end)
            {

                int sum = arr1[start] + arr1[end];

                if (sum == arr2[ndstart] || arr1[start] == arr2[ndstart] || arr1[end] == arr2[ndstart])
                {

                    listArr.Remove(arr1[start]);
                    listArr.Remove(arr1[end]);


                    arr1 = listArr.ToArray();

                    ndstart++;

                    start = 0;
                    end = arr1.Length - 1;
                    continue;
                }
                if (arr2[ndstart] > sum)
                {
                    start++;
                }
                else
                {
                    end--;
                }

            }







        }



        interface ICovariant<out T>
        {
            T GetItem();
        }

        class Animal { }
        class Dog : Animal { }

        class CovariantExample : ICovariant<Dog>
        {
            public Dog GetItem() => new Dog();
        }

        class Program
        {
            static void Main()
            {
                ICovariant<Dog> dogProvider = new CovariantExample();
                ICovariant<Animal> animalProvider = dogProvider; // Covariance: Dog → Animal
                Animal animal = animalProvider.GetItem();
                Console.WriteLine(animal.GetType().Name); // Output: Dog
                IEnumerable<string> test = default;

                IEnumerable<object> test2 = test;

                void GetResult(object ocj)
                {

                }

                Action<string> obj = GetResult;


            }
        }

        delegate void AnimalDelegate(Animal animal);
        interface IContravariant<in T>
        {
            void SetItem(T item);
        }

        class Animal1 { }
        class Dog1 : Animal1 { }

        class ContravariantExample : IContravariant<Animal1>
        {
            public void SetItem(Animal1 item) => Console.WriteLine(item.GetType().Name);
        }

        class Program2
        {
            static void ProcessAnimal(Animal animal) => Console.WriteLine("Processing animal");

            static void ProcessDog(Dog dog) => Console.WriteLine("Processing dog");

            static void Main()
            {
                static void SetObject(object o) { }
                Action<Animal> actObject = SetObject;
                // An object that is instantiated with a more derived type argument
                // is assigned to an object instantiated with a less derived type argument.
                // Assignment compatibility is preserved.
                Action<Dog> actString = actObject;

                IContravariant<Animal1> animalSetter = new ContravariantExample();
                IContravariant<Dog1> dogSetter = animalSetter; // Contravariance: Animal → Dog
                dogSetter.SetItem(new Dog1()); // Output: Dog
            }










        }


        public void GetCommonList(List<int> list1, List<int> list2)
        {


            var commonList = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {


                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        commonList.Add(list1[i]);
                    }
                }



            }

            Console.WriteLine("Common Elements are:" + string.Join(" ", commonList.Distinct()));
        }

    }
}


