using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape//inheritance
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Sphere";//encapsulation
        base.OnMouseDown();
    }
}
