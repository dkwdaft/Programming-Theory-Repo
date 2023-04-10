using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Shape
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Plane";
        base.OnMouseDown();
    }
}
