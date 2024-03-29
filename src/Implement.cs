﻿using System.Text.RegularExpressions;

namespace Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Algorithm
    {
        public int BinarySearch<T>(ref List<T> list, T value)
        {
            if (list == null || list.Count <= 0)
            {
                return -1;

            }

            if (!list.Contains(value))
            {
                return -2;
            }

            int start = 0;
            int end = list.Count - 1;
            int middleIndex;
            int middleValue;
            int convertValueToInt = Convert.ToInt32(value);
            while (start <= end)
            {
                middleIndex = start + ((end - start) / 2);
                middleValue = Convert.ToInt32(list[middleIndex]);
                if (convertValueToInt > middleValue)
                {
                    start = middleIndex + 1;
                }
                else if (convertValueToInt < middleValue)
                {
                    end = middleIndex - 1;
                }
                else
                {
                    return middleIndex;
                }
            }

            return -1;
        }

        public int IndexOf(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    value = i;
                    return value;
                }
            }

            return -1;
        }

        public List<int> BubbleSort(List<int> list)
        {
            bool inverse = true;
            int c = 0;
            while (inverse)
            {
                inverse = false;
                for (int i = 0; i < list.Count - 1; ++i)
                {
                    if (list[i] > list[i + 1])
                    {
                        c = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = c;
                        inverse = true;
                    }
                }
            }

            return list;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static bool IsPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2 || n % 2 == 0)
            {
                return false;
            }

            int d = 3;
            while (d * d <= n)
            {
                if (n % d == 0)
                {
                    return false;
                }

                d += 2;
            }

            return true;
        }

        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public int Fibonacci(int n)
        {
            if (n < 0 || n <= 1)
            {
                return n;
            }
            var next = 1;
            var prev = 0;

            for (int i = 1; i <= n; i++)
            {
                var sum = prev + next;
                prev = next;
                next = sum;

            }

            return prev;
        }

        public int FibonacciRecursive(int n)
        {
            if (n < 0 || n <= 1)
            {
                return n;
            }

            return this.FibonacciRecursive(n - 1) + this.FibonacciRecursive(n - 2);
        }

        public double Function(double x) => (x * x * x) - x - 1;

        public double Root(double a, double b, double eps)
        {
            double fa = Function(a);
            double fb = Function(b);
            int sa, sb;  // Знаки функции в точках a,b

            if (fa > 0)
            {
                sa = 1;
            }
            else if (fa < 0)
            {
                sa = -1;
            }
            else
            {
                return a;
            }

            if (fb > 0)
            {
                sb = 1;
            }
            else if (fb < 0)
            {
                sb = -1;
            }
            else
            {
                return b;
            }

            while (Math.Abs(b - a) > eps)
            {
                double c = (a + b) / 2;
                double fc = Function(c);
                int sc = 0;
                if (fc > 0)
                {
                    sc = 1;
                }
                else if (fc < 0)
                {
                    sc = -1;
                }

                if (sa * sc <= 0)
                {
                    b = c;
                    sb = sc;
                }
                else
                {
                    a = c;
                    sa = sc;
                }

            }

            return (a + b) / 2;
        }

        public double[] GenerateRandomNumbers(ref double[] arr)
        {
            Random rnd = new Random();
            if (arr.Length <= 0)
            {
                throw new Exception("The array length is 0");
            }

            for (int ctr = 0; ctr <= arr.Length - 1; ctr++)
            {
                arr[ctr] = new Random().Next(1, 100);
            }

            return arr;
        }
        public bool StartWith(string prefix, string postfix)
        {
            bool result = true;

            if (postfix.Length > postfix.Length)
            {
                result = false;
            }

            for (int i = 0; i < postfix.Length; i++)
            {
                if (!postfix[i].Equals(prefix[i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static string GetMiddle(string s)
        {
            var temp = s.ToCharArray();
            var middle = s.Length / 2;
            var res = string.Empty;
            if (s.Length % 2 != 0)
            {
                for (int i = 0; i < temp.Length; ++i)
                {
                    res = temp[middle].ToString();
                    break;
                }
            }
            else if (s.Length % 2 == 0)
            {
                var a = string.Empty;
                for (int i = 0; i < temp.Length; ++i)
                {
                    res += temp[middle - 1];
                    a += temp[middle];
                    res += a;
                    break;
                }
            }

            return res;
        }

        public static long DigPow(int n, int p)
        {
            var sum = Convert.ToInt64(n.ToString().Select(s => Math.Pow(int.Parse(s.ToString()), p++)).Sum());
            return sum % n == 0 ? sum / n : -1;
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }

        public static string ReverseString(string str) => new string(str.Reverse().ToArray());

        public static int Summation(int num) => num * (num + 1) / 2;

        public static string SeriesSum(int n)
        {
            return (from i in Enumerable.Range(0, n) select 1.0 / ((3 * i) + 1)).Sum().ToString("0.00");
        }

        public void NumberIsPrimes(int n, int[] primes)
        {
            int numPrimes = 0;
            primes[0] = 2;
            ++numPrimes;
            int p = 3;
            while (numPrimes < n)
            {
                bool prime = true;
                for (int i = 0; prime && i < numPrimes; ++i)
                {
                    int d = primes[i];
                    if (d * d > p)
                    {
                        break;
                    }
                    else if (p % d == 0)
                    {
                        prime = false;
                    }
                }

                if (prime)
                {
                    primes[numPrimes] = p;
                    ++numPrimes;
                }

                p += 2;
            }
        }

        public void IncreaseKapasiteIncreasingCount(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list.Add(i);
                Console.WriteLine("Capacity after {0} element: {1}", i, list.Capacity);
            }
        }

        public static string Maskify(string cc)
        {
            int len = cc.Length;
            if (len <= 4)
                return cc;

            return cc.Substring(len - 4).PadLeft(len, '#');
        }
        public void Factorissation(long n)
        {
            int d = 2;
            int k = 0;
            while (d <= n)
            {
                if (n % d == 0)
                {
                    Console.WriteLine(d);
                    ++k;
                    n /= d;
                }
                else if (d == 2) { ++d; }
                else
                {
                    d += 2;
                }
            }

            Console.WriteLine("\n");
            if (k == 1)
            {
                Console.WriteLine("Prime\n");
            }
        }

        int GCD(int m, int n)
        {
            while (n != 0)
            {
                int r = m % n;
                m = n;
                n = r;
            }

            return m;
        }

        long Powmod(long a, long k)
        {
            long b = 1;

            while (k > 0)
            {
                if (k % 2 == 0)
                {
                    k /= 2;
                    a *= a;
                }
                else
                {
                    k--;
                    b *= a;
                }
            }

            return b;
        }

        public static object[] RemoveEveryOther(object[] arr) =>
            arr.Where((x, y) => ++y % 2 != 0).
                Select(x => x).
                ToArray();
        //Message Validator  https://www.codewars.com/kata/5fc7d2d2682ff3000e1a3fbc/solutions/csharp
        public static bool isAValidMessage(string message)
        {

            MatchCollection reg = Regex.Matches(message, @"(\d+)([A-z]*)");

            bool res = true;
            for (int i = 0; i < reg.Count(); i++)
            {
                if (reg[i].Groups[1].Value != reg[i].Groups[2].Length.ToString())
                {
                    res = false;
                }
            }
            return res;
        }
    }
}
