using System.Collections;
using System.Collections.Generic;
using Assignment29;
using UnityEngine;

public class testCustomObject : MonoBehaviour
{
    void Start()
    {
        CustomObject customObject1 = new CustomObject(1234,"custom1");
        print($"Custom Name is {customObject1.name}, and Custome ID is {customObject1.id}");

        CustomObject customObject2 = new CustomObject(5678,"custom2");

        print($"The result of == operator is {customObject1 == customObject2}");
        print($"The result of != operator is {customObject1 != customObject2}");

    }
}
