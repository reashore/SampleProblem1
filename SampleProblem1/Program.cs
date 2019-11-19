﻿using static System.Console;

namespace SampleProblem1
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            int[] state = {1, 0, 0, 0, 0, 1, 0, 0};
            int days = 1;
            int[] result = Problem1.EvolveState(state, days);
            PrintArray(state);
            PrintArray(result);
            WriteLine();

            state = new [] {1, 1, 1, 0, 1, 1, 1, 1};
            days = 2;
            result = Problem1.EvolveState(state, days);
            PrintArray(state);
            PrintArray(result);
            WriteLine();
        }

        private static void PrintArray(int[] array)
        {
            for (int n = 0; n < array.Length; n++)
            {
                Write($"{array[n]}, ");
            }

            WriteLine();
        }
    }
}
