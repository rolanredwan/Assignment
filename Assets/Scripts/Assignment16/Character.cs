using System.Collections;
using System.Collections.Generic;
using Assignment16;
using UnityEngine;
namespace Assignment16
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.Health = health;
            position = new Position();
        }
        public int Health
        {
            get { return this.health; }
            set
            {
                this.health = value;
                if (value > 100)
                {
                    this.health = 100;
                }
                if (value < 0)
                {
                    this.health = 0;
                }
            }
        }
        public virtual void DisplayInfo()
        {
            Debug.Log("the name is " + this.name + "The health = " + this.Health);
            position.PrintPosition(0, 0, 0);
        }
        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
        }

        public void Attack(int damage, Character target, string attackType)
        {
            target.Attack(damage, target);
            Debug.Log("Attack Type is " + attackType);
        }
    }
}
