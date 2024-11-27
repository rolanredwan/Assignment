using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment18_Part2
{
    public class Inventory
    {
        private List<string> itemNames;
        public Inventory()
        {
            this.itemNames = new List<string>();
        }
        public void AddItem(string item)
        {
            this.itemNames.Add(item);
        }
        public void ShowItems()
        {
            for (int i = 0; i < this.itemNames.Count; i++)
            {
                Debug.Log(this.itemNames[i]);
            }
        }

        public static Inventory operator +(Inventory inv1, Inventory inv2)
        {
            Inventory inv3 = new Inventory();
            foreach (string i in inv1.itemNames)
            {
                inv3.itemNames.Add(i);
            }
            foreach (string i in inv2.itemNames)
            {
                inv3.itemNames.Add(i);
            }
            return inv3;
        }
    }
}
