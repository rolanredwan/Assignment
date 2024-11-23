using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position)
        {
            this.name = name;
            this.Health = health;
            position = new Position();
        }

        public Soldier() : base("No name", 100, new Position(0, 0, 0)) { }
        public override void DisplayInfo(){
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
