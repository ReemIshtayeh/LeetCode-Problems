using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static string RepeatString(this string str, int num)
        {
            string msg = "";
            for (int i = 0; i < num; i++)
            {
                msg += str;
            }
            return msg;
        }
    }
}