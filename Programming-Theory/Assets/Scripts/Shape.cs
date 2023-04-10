using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour//inheritance
{
    
    public virtual void OnMouseDown()//polymorphism 
    {
        DisplayText(name);
    }

    public virtual void DisplayText(string name )//polymorphism
    {
        string message = $"I am a{name}";
        UIManager.Instance.labelText.text = message;
        Debug.Log(message);
    }
}
