using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment14
{
    public class Enemy : Character
    {
        public Enemy(string name, int health) : base(name, health)
        {
            this.Health = health;
            this.Name = name;
        }

        public int Attack(int amount)
        {
            this.Health -= amount;
            return this.Health;
        }
    }
}
