using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {   // Part1 :
            int health = 100;
            object obj = health as object;
            int heal = (int)obj;
            Debug.Log($"The Original int Value = {health}");
            Debug.Log($"The Boxed Value = {obj}");
            Debug.Log($"The Modified and Unboxed Value = {heal}");
        }
    }
}
