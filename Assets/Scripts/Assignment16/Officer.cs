using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment16
{
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position)
        {
            this.name = name;
            this.Health = health;
            position = new Position();
        }
        public override void DisplayInfo(){
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
