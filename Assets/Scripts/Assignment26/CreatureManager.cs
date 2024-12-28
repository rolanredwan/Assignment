using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using System;
using Assignment26;
public class CreatureManager : MonoBehaviour
{
    void Start()
    {
        Kangaroo kangaroo = new Kangaroo();
        Duck duck = new Duck();
        Creature[] creatures = { kangaroo, duck };

        ISwimmable[] swimmables = { duck };
        IRunnable[] runnables = { kangaroo, duck };
        IJumpable[] jumpables = { kangaroo };

        foreach (Creature c in creatures)
        {
            c.Speak();
        }

        foreach (IRunnable r in runnables)
        {
            r.Run();
        }

        foreach (IJumpable j in jumpables)
        {
            j.Jump();
        }

        foreach (ISwimmable s in swimmables)
        {
            s.Swim();
        }



    }
    void Update()
    {

    }
}
