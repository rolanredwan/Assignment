using System.Collections.Generic;
using Assignment29;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Animal cat = new Cat();
        cat.MakeSound();
        cat.Move();
        Cat c = cat as Cat;
        c.MakeSound();
        c.Move();



        Cat cat1 = new Cat();
        Warrior warrior = new Warrior();
        List<ICanFight> values = new List<ICanFight> {cat1, warrior };
        foreach (var i in values)
        {
            i.Attack();
        }
        if(cat1 is Cat) Debug.Log("The Object is a Cat");
        if(warrior is Warrior) Debug.Log("The Object is a Warrior");


    }

}
