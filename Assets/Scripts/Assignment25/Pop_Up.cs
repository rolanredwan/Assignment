using UnityEngine;
namespace Assignment25
{
    public class Pop_Up : MonoBehaviour
    {
        public Transform cube;
        void Update()
        {
            transform.LookAt(cube.transform);
        }
    }
}