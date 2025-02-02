using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            var num = 10;
            var name = "Roaln";
            var isEven = num % 2 == 0 ? $"The number {num} is even" : $"The number {num} is odd";

            Debug.Log(name);
            Debug.Log(isEven);
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now);
            Debug.Log(System.DateTime.Today.DayOfWeek);



        }
        void Update()
        {

        }
    }
}
