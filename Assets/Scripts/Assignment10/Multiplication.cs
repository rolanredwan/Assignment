using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Multiplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int result1 = Multiply(i, 5);
            Debug.Log(i + " * " + 5 + " = " + result1);
        }
    }
    int Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }
    // Update is called once per frame
    // void Update()
    // {

    // }
}
