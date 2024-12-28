using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
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

        public void CountOccurence(int number, int data)
        {
            // 13839 / 10 = 1383

            int count = 0;

            while (data != 0)
            {
                int n = data % 10;

                if (n == number)
                {
                    count++;
                }
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

        public void Reverse3DArray(int[,,] array3D)
        {
            // { { {1,2}, {2,9}}, {{1,2}, {3,9}}}

            for (int i = array3D.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = array3D.GetLength(1) - 1; j >= 0; j--)
                {
                    for (int k = array3D.GetLength(2) - 1; k >= 0; k--)
                    {
                        Console.Write(array3D[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write(" " + array3D[(array3D.GetLength(0) - 1 - i), (array3D.GetLength(1) - 1 - j), (array3D.GetLength(2) - 1 - k)]);
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
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
                if (item > max)
                {
                    max = item;
                }
            }

            Console.WriteLine("Max value is" + max);
        }

        public void ReverseArrayWithDiffTeq()
        {
            int[] arr = new int[] { 1, 2, 3, 5, 6, 7, 8 };

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
            int[] value = { 1, 23, 45, 678 };
            int cnt = 1;
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                while (value[i] > 0)
                {
                    value[i] = value[i] / 10;
                    cnt++;
                }

                if (cnt % 2 == 0)
                {
                    count++;
                }

            }



            Console.WriteLine(count);
        }

        public void FindMaxSumIn2DArray()
        {
            int[,] Elements = { { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 } };

            int max = 0;
            for (int i = 0; i < Elements.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Elements.GetLength(1); j++)
                {
                    sum += Elements[i, j];
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

        public void FindCielingOrFloorOfCharacter(char character, bool findFloor)
        {
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

                arr = GetMaxArray(arr, i, last);

            }
        }

        public void InsertionSort()
        {
            int[] arr = new int[] { 5, 3, 4, 2, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        public int[] GetMaxArray(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

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

                    variable *= 2;

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


         var distdict =   obj2.DistinctBy(x => x.GetType().GetProperty("test3"));
          var details =  obj2.ExceptBy(obj.Select(x => x.GetType()?.GetProperty("test1")?.GetValue(x)), x => x.GetType().GetProperty("test1")?.GetValue(x));

            foreach(var items in distdict)
            {
                Console.WriteLine(items.GetType()?.GetProperty("test1")?.GetValue(items));
            }
        }


        public bool CheckPrime(int n)
        {
            int i = 2;

            if(n <= 1)
            {
               
                return false;
            }

            while (i * i <= n)
            {
                
                if(n % i == 0)
                {
                    return false;
                }

            }

            return true;
        }

        public void GiveListPrime(int n)
        {

            bool[] primeList = new bool[n+1];

            for(int i= 2; i*i <= n; i++)
            {

                for(int j= i * 2; j <= n; j += i)
                {
                    if (!primeList[j])
                    {
                        primeList[j] = true;
                    }
                }



            }

            for(int i=2; i < primeList.Length; i++)
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
            while(start <= end)
            {
                 mid = start + (end - start) / 2;


                if(mid * mid == n)
                {
                    Console.WriteLine(mid);
                    return;
                }

                if(mid *  mid > n)
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
            for(int i =0; i < p; i++)
            {
                while(root * root <= n)
                {
                    root += incr;
                }

                root -= incr;
            }

            Console.WriteLine(root);
        }


    }
    }


