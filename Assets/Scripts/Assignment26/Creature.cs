using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A Creature Makea a Aound");
        }
    }

    public interface IRunnable
    {
        public void Run();
    }

    public interface IJumpable
    {
        public void Jump();
    }

    public interface ISwimmable
    {
        public void Swim();
    }


}



