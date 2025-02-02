using System.Diagnostics;
using Unity.VisualScripting;

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

        public static string RepeatString(this string str, int count)
        {
            string text = "";
            for (int i = 1; i <= count; i++)
            {
                text += str;
            }
            return text;
        }


    }
}