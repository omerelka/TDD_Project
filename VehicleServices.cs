using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using TDD_Proj.Models;

namespace TDD_Proj.Services
{
    public static class VehicleServices
    {
        /// <summary>
        /// Most recent sort duration in milliseconds.
        /// </summary>
        public static int TimeToSort { get; private set; }

        // public static List<Vehicle> SortByYearDescending(List<Vehicle> vehicles)
        // {
        //     int startMs = DateTime.Now.Millisecond;
        //     var arr = vehicles.ToArray();
        //     int n = arr.Length;
        //     for (int i = 0; i < n - 1; i++)
        //     {
        //         for (int j = 0; j < n - i - 1; j++)
        //         {
        //             if (arr[j].Year < arr[j + 1].Year)
        //             {
        //                 var tmp = arr[j];
        //                 arr[j] = arr[j + 1];
        //                 arr[j + 1] = tmp;
        //             }
        //         }
        //     }
        //     TimeToSort =  startMs -DateTime.Now.Millisecond ;
        //     return new List<Vehicle>(arr);
        // }
        public static List<Vehicle> SortByYearDescending(List<Vehicle> vehicles)
        {
            int startMs = DateTime.Now.Millisecond;
            var sorted = MergeSort(vehicles);
            TimeToSort = Math.Abs(startMs - DateTime.Now.Millisecond);
            return sorted;
        }

        // Recursive split
        private static List<Vehicle> MergeSort(List<Vehicle> list)
        {
            if (list.Count <= 1)
                return new List<Vehicle>(list);

            int mid = list.Count / 2;
            var left = MergeSort(list.GetRange(0, mid));
            var right = MergeSort(list.GetRange(mid, list.Count - mid));
            return Merge(left, right);
        }

        // Merge two sorted halves into one sorted (descending)
        private static List<Vehicle> Merge(List<Vehicle> left, List<Vehicle> right)
        {
            var result = new List<Vehicle>(left.Count + right.Count);
            int i = 0, j = 0;
            while (i < left.Count && j < right.Count)
            {
                if (left[i].Year >= right[j].Year)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            // Append any leftovers
            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }




        // Compute average Year (0 if empty)
        public static int CalculateAverageYear(List<Vehicle> vehicles)
        {
            if (vehicles.Count == 0) return 0;
            long sum = 0;
            foreach (var v in vehicles) sum += v.Year;
            return (int)(sum / vehicles.Count);
        }
    }
}