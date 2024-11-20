using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment13;
public class Assig13 : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player();
        player1.InitializePlayer("Rolan", 100);
        Debug.Log(player1.Heal(true));
        player1.Heal(150);

        Debug.Log("-----------------");

        Player player2 = new Player();
        player2.InitializePlayer("Remas", 80);
        Debug.Log(player2.Heal(false));
        player2.Heal(-10);

        Debug.Log("-----------------");

        Player.ShowPlayerCount();
    }








    // // Update is called once per frame
    // void Update()
    // {

    // }
}
