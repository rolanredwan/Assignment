using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class CustomObject
    {
        public int id;
        public string name;

        public CustomObject(int id, string name)
        {
            this.name = name;
            this.id = id;
        }

        public override string ToString()
        {
            return $"[ID: {this.id}, Name: {this.name}]";
        }

        public override bool Equals(object obj)
        {
            CustomObject customObject = obj as CustomObject;
            if (obj == null) return false;
            if (customObject.name == this.name && customObject.id == this.id) return true;
            return false;
        }

        public static bool operator ==(CustomObject custom1, CustomObject custom2)
        {
            if (custom1.Equals(null) && custom1.Equals(null)) return false;
            if (custom1.name.Equals(custom2.name) && custom1.id == custom2.id) return true;
            return false;
        }

        public static bool operator !=(CustomObject custom1, CustomObject custom2)
        {
            if (custom1.Equals(null) && custom1.Equals(null)) return false;
            if (!custom1.name.Equals(custom2.name) && !(custom1.id == custom2.id)) return true;
            return false;
        }
    }
}
