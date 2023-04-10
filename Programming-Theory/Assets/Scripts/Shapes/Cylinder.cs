using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Cylinder";
        base.OnMouseDown();
    }
}
