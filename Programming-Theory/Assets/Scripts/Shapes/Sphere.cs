using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Sphere";
        base.OnMouseDown();
    }
}
