using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class Assignment27_Test : MonoBehaviour
    {
        void Start()
        {
            int a = 10;
            int b = 20;

            IncrementNum1(a);
            Debug.Log(a);

            // ------------------------------------

            IncrementNum2(ref b);
            Debug.Log(b);

            // ------------------------------------

            int d;
            TestOutKeyword(out d);
            Debug.Log(d);
        }

        public void IncrementNum1(int num){
            num+= 10 ;
        }

        public void IncrementNum2(ref int num){
            num += 10;
        }

        public void TestOutKeyword(out int num){
            num = 20;
        }
    }
}
