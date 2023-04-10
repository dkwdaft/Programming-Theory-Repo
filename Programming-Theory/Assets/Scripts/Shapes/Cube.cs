using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Cube";
        base.OnMouseDown();
    }
}
