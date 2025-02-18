using System;
using UnityEngine;
namespace Assignment35
{   // Part3 :
    public delegate void LogMessage();
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            Action logMessage = LogMessage;
            logMessage();

            // ----------------------------------
            Debug.Log($"Square : {square(5)}");

            // ----------------------------------

            int num = 4;
            Debug.Log($"IS {num} even? {isEven(4)}");

        }
        void LogMessage() => Debug.Log("Hello from Action delegate!");

        // ----------------------------------
        public Func<int, int> square = (number) => number * number;

        // ----------------------------------
        Predicate<int> isEven = (num) => num % 2 == 0 ? true : false;

    }
}
