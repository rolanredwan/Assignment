using System;
using UnityEngine;
namespace Assignment29
{
    public class Exception : MonoBehaviour
    {
        void Start()
        {
            int playerScore = 100;
            int diviser = 0;
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / diviser;
            }
            catch (DivideByZeroException)
            {
                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning upresources.");
            }
        }

    }
}
