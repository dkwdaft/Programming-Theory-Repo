using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Shape//inheritance
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Plane";//encapsulation
        base.OnMouseDown();
    }
}
