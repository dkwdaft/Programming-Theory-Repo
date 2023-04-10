using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    
    public virtual void OnMouseDown()//polymorphism 
    {
        DisplayText(name);
    }

      void DisplayText(string name )//polymorphism
    {//abstraction
        string message = $"I am a {name}";
        UIManager.Instance.labelText.text = message;
        Debug.Log(message);
    }
}
