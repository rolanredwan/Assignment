using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
    public UnityEvent onEventTriggered;
    void Start()
    {
        onEventTriggered = new UnityEvent();
        onEventTriggered.AddListener(OnEventResponse);
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            onEventTriggered?.Invoke();
        }
    }
    public void OnEventResponse()
    {
        Debug.Log("The event has been triggered!");
    }
}
