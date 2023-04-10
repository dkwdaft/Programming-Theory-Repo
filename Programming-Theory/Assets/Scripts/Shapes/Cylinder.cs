using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape//inheritance
{
    public override void OnMouseDown()//polymorphism 
    {
        name = "Cylinder";//encapsulation
        base.OnMouseDown();
    }
}
