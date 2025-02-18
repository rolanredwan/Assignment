using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {   // Part 4&5 :
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        int Compare(int x, int y) => y.CompareTo(x);

        // ---------------------------------------------------------------
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };

        void Start()
        {
            numbers.Sort(Compare);

            Debug.Log(string.Join(", ", numbers));

        }

    }
}

