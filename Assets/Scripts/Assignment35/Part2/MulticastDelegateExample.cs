using UnityEngine;
namespace Assignment35
{
    delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {   // Part2 :
        MathOperation operation;
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation(5);
        }
        void DoubleNumber(int number) => Debug.Log($"Double : {number + number}");
        void SquareNumber(int number) => Debug.Log($"Square : {number * number}");
        void CubeNumber(int number) => Debug.Log($"Cube : {number * number * number}");

    }
}
