using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            int fn1 = FibonacciRecursive(10);
            Debug.Log(fn1);
            int fn2 = FibonacciRecursive(30);
            Debug.Log(fn2);

            int fn3 = FibonacciIterative(10);
            Debug.Log(fn3);
            int fn4 = FibonacciIterative(30);
            Debug.Log(fn4);
        }

        public int FibonacciRecursive(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public int FibonacciIterative(int n)
        {

            int[] nums = new int[n + 1];
            nums[0] = 0;
            nums[1] = 1;
            if (n == 0) return 0;
            if (n == 1) return 1;
            for (int i = 2; i <= n; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];

            }
            return nums[n];

        }
    }

}

