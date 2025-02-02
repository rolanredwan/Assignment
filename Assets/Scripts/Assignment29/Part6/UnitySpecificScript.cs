using UnityEngine;
namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        void OnEnable()
        {
            print("GameObject Enabled!");
        }
        void Start()
        {
            print("GameObject Started!");

            // ------------------------------------------------------------------

            if (GameObject.Find("TargetObject"))
            {
                print("Found object by name: TargetObject");
            }
            else
            {
                print("No TargetObject found.");
            }

            // ------------------------------------------------------------------

            if (GameObject.FindGameObjectWithTag("Joker"))
            {
                print("Found object by tag: Joker");
            }
            else
            {
                print("No Joker object found");
            }

            // ------------------------------------------------------------------

            if (GameObject.FindObjectOfType<Light>())
            {
                print(" Found object of type Light: Directional Light");
            }
            else
            {
                print("No Light object found.");
            }
        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D))
            {
                GameObject.Find("TargetObject").SetActive(false);
                print("TargetObject deactivated!");//**************************** setActive
            }
        }
        void OnDisable()
        {
            print("GameObject Disable!!");
        }

    }
}
