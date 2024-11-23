using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_Part1
{
    public class GameUtils
    {
        public static string DescribeItem<T>(T something){
            return "This item is a " + something;
        }
    }
}
