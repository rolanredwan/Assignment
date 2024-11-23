using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment18_Part1
{
    public class GameContainer<T>
    {
        public T item;
        public  T SetItem<T>(T item)
        {
            return item = item;
        }
        public  T GetItem<T>(T item)
        {
            return SetItem<T>(item);
        }

    }
}

