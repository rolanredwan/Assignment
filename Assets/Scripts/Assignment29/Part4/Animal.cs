using UnityEngine;
namespace Assignment29
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal Sound");
        }

        public void Move()
        {
            Debug.Log("Animal Moves");
        }
    }
}