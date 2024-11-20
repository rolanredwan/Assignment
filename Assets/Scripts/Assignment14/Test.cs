using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Assignment14;
public class Test : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("Remas", 100);

        Debug.Log("The Name of Player is " + player.Name + " and the health = " + player.Health);
        Debug.Log(player.Heal(190));

        Enemy enemy = new Enemy("hamza", 100);

        Debug.Log("The Name of Enemy is " + enemy.Name + " and the health = " + enemy.Health);
        
        int newHealth = player.Heal(enemy.Attack(50));
        Debug.Log("Your new health is " + newHealth);


    }


}
