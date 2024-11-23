using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment16;
public class CharacterTest : MonoBehaviour
{
    void Start()
    {
        // Position soldierPosition = new Position(0, 0, 0);
        Soldier soldier = new Soldier();
        soldier.name = "Hamza";

        Position officerPosition = new Position(0, 0, 0);
        Officer officer = new Officer("Remas", 100, officerPosition);


        Character[] characters = new Character[2];
        characters[0] = soldier;
        characters[1] = officer;
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].DisplayInfo();
        }


        Officer officer1 = new Officer("mohamed", 100, officerPosition);
        Debug.Log("Health of soldier defore attack = " + soldier.Health);
        officer1.Attack(50, soldier, "Shooting");
        Debug.Log("Health of soldier after attack = " + soldier.Health);
    }

}
