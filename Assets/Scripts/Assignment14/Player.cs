using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{

    public class Player : Character
    {
        public Player(string name, int health) : base(name, health)
        {
            this.Health = health;
            this.Name = name;
        }
        public Player() : this("", 0) { }
        public int Heal(int amount)
        {
            Health = amount;
            return Health;
        }
    }
}
