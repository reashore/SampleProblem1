using static System.Console;

namespace SampleProblem1
{
    public class Program
    {
        public static void Main()
        {
            int[] states = {1, 0, 0, 0, 0, 1, 0, 0};
            int days = 1;
            int[] result = EvolveState(states, days);
            PrintArray(states);
            PrintArray(result);
            WriteLine();

            states = new [] {1, 1, 1, 0, 1, 1, 1, 1};
            days = 2;
            result = EvolveState(states, days);
            PrintArray(states);
            PrintArray(result);
            WriteLine();
        }

        private static int[] EvolveState(int[] state, int days)
        {
            int[] state1 = new int[10];
            int[] state2 = new int[10];

            state1[0] = 0;
            state1[9] = 0;

            for (int n = 1; n <= 8; n++)
            {
                state1[n] = state[n - 1];
            }

            for (int day = 1; day <= days; day++)
            {
                state2[0] = 0;
                state2[9] = 0;

                for (int n = 1; n <= 8; n++)
                {
                    state2[0] = 0;
                }

                for (int n = 1; n <= 8; n++)
                {
                    int previous = state1[n - 1];
                    int next = state1[n + 1];

                    bool condition1 = previous == 0 && next == 0;
                    bool condition2 = previous == 1 && next == 1;

                    if (condition1 || condition2)
                    {
                        state2[n] = 0;
                    }
                    else
                    {
                        state2[n] = 1;
                    }
                }

                for (int n = 1; n <= 8; n++)
                {
                    state1[n] = state2[n];
                }
            }

            int[] result = new int[8];

            for (int n = 0; n < 8; n++)
            {
                result[n] = state1[n + 1];
            }

            return result;
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
