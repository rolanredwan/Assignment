using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment18_Part2
{
    public class Inventory
    {
        private List<string> itemNames;

        // public List<string> ItemNames
        // {
        //     set { this.itemNames = value; }
        //     get { return this.itemNames; }
        // }
        public void AddItem(string item)
        {
            this.itemNames.Add(item);
        }
        public void ShowItems()
        {
            for (int i = 1; i <= this.itemNames.Count; i++)
            {
                Debug.Log(this.itemNames[i]);
            }
        }

        public static Inventory operator +(Inventory inv1, Inventory inv2)
        {
            Inventory inv3 = inv1 + inv2;
            return inv3;
        }
    }
}
