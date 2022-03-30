using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.TryParse(s, out var x) ? x : -1);

        bool unSortedValueFound = false;
            bool sorted = false;
            int count = 0;
            while (!sorted){
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        arr[i] = arr[i] + arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                        unSortedValueFound = true;
                        count += 1;
                    }
                }
                if (!unSortedValueFound) sorted = true;
                unSortedValueFound = false;
            }
            Console.WriteLine($"Array is sorted in {count} swaps.\nFirst Element: {arr[0]}\nLast Element: {arr[n-1]}");
    }
    }
