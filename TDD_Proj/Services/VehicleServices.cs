using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using TDD_Proj.Models;
using System.ComponentModel;

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
        public static BindingList<Vehicle> SortByYearDescending(BindingList<Vehicle> vehicles)
        {
            int startMs = DateTime.Now.Millisecond;
            var sorted = MergeSort(vehicles);
            TimeToSort = Math.Abs(startMs - DateTime.Now.Millisecond);
            return sorted;
        }

        // Recursive split
        private static BindingList<Vehicle> MergeSort(BindingList<Vehicle> list)
        {
            // Base case: single item or empty
            if (list.Count <= 1)
                // Copy to a new list so we don’t mutate the original
                return new BindingList<Vehicle>(list.ToList());

            int mid = list.Count / 2;
            // Split into two BindingLists
            var leftList = new BindingList<Vehicle>(list.Take(mid).ToList());
            var rightList = new BindingList<Vehicle>(list.Skip(mid).ToList());

            // Recursively sort each half
            var left = MergeSort(leftList);
            var right = MergeSort(rightList);

            // Merge sorted halves
            return Merge(left, right);
        }

        // Merge two sorted halves into one sorted (descending)
        private static BindingList<Vehicle> Merge(BindingList<Vehicle> left, BindingList<Vehicle> right)
        {
            var result = new BindingList<Vehicle>();
            int i = 0, j = 0;

            // Standard merge loop
            while (i < left.Count && j < right.Count)
            {
                if (left[i].Year >= right[j].Year)
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            // Flush any remaining
            while (i < left.Count) result.Add(left[i++]);
            while (j < right.Count) result.Add(right[j++]);

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