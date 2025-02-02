using System.Collections;
using System.Collections.Generic;
using Assignment29;
using Unity.VisualScripting;
using UnityEngine;

public class TestUtilities : MonoBehaviour
{
    void Start()
    {
        int sumOfNums = Utilities.Add(2, 4, 5, 6, 7, 4, 9, 10);
        Debug.Log($"Sum of list numbers = {sumOfNums}");

        Debug.Log(Utilities.RepeatString("Hello", 3));
    }

}
