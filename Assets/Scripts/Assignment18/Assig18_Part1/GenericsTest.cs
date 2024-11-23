using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18_Part1;
public class Genericstest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> gc = new GameContainer<string>();
        Debug.Log(gc.GetItem("Sorted ITem : " + gc.SetItem("Healing Potion")));
        Debug.Log(GameUtils.DescribeItem(gc.GetItem(gc.SetItem("Healing Potion"))));
    }
}
