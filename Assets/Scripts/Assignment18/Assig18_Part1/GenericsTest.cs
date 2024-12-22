using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18_Part1;
public class Genericstest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> gc = new GameContainer<string>();
        gc.SetItem("Healing Potion");
        Debug.Log("Sorted Item : " + gc.GetItem());
        Debug.Log(GameUtils.DescribeItem(gc.GetItem()));
    }
}
