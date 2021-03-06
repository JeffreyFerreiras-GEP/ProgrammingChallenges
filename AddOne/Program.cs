﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample = { 1, 3, 2, 4 };
            int[] result = AddOne(sample);

            int[] sample2 = { 5, 4, 8, 9 };
            int[] result2 = AddOne(sample2);

            int[] sample3 = { 9, 8, 9, 9 };
            int[] result3 = AddOne(sample3);

            int[] sample4 = { };
            int[] result4 = AddOne(sample4);

            int[] sample5 = { 9, 9, 9, 9 };
            int[] result5 = AddOne(sample5);
        }

        static int[] AddOne(int[] sample)
        {
            return AddOne(sample, sample.Length - 1);
        }

        static int[] AddOne(int[] arr, int index)
        {
            if(index < 0)
            {
                return PrependOne(arr);
            }

            arr[index] += 1;

            if(arr[index] >= 10)
            {
                arr[index] = arr[index] % 10;

                return AddOne(arr, index - 1);
            }

            return arr;
        }

        static int[] PrependOne(int[] arr)
        {
            var newArray = new int[arr.Length + 1];
            newArray[0] = 1;

            for(int i = 1; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }

            return newArray;
        }
    }
}
