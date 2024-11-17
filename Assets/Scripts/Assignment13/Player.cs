using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
        Debug.Log("Player No. -" + playerCount + "- Name of Player is " + playerName + " and the health of player is " + health);
    }
    public void Heal(int amount)
    {
        if (amount >= 100)
        {
            health = 100;
        }
        if (amount < 0)
        {
            health = 0;
        }
        Debug.Log(health);
    }
    public int Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
        }
        return health;
    }
    public static void ShowPlayerCount()
    {
        Debug.Log("No. of Player = " + playerCount);
    }
}
