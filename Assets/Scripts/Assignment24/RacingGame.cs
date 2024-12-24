
using UnityEngine;
using Assignment24;

public class RacingGame : MonoBehaviour
{
    public RaceState raceState;
    public void simulateRace()
    {
        switch (raceState)
        {
            case RaceState.Start:
                Debug.Log("The race is about to begin. Get Ready!!");
                break;
            case RaceState.Accelerate:
                Debug.Log("You press a sharp turn.The car speed up!!");
                break;
            case RaceState.Turn:
                Debug.Log("You abroch a sharp turn. Be careful not to crash!!");
                break;
            case RaceState.Crach:
                Debug.Log("you hit a barrier. The race is over.");
                break;
            case RaceState.Finish:
                Debug.Log("YOu crossed the finish line. Well done!");
                break;
            default:
                Debug.Log("This state is not defined. Something is wrong");
                break;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        simulateRace();
    }
}

