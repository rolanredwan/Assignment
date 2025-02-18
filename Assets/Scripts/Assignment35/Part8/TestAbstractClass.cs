using UnityEngine;
namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample dce = new DerivedClassExample();
            dce.PerformAction();
            dce.PrintInfo();
        }
    }
}
