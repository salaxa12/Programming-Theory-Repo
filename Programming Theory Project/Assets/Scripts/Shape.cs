using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Shape : MonoBehaviour
{
       
    public string color;


    public string displayText()
    {
        return "I am a shape";
    }


    // ENCAPSULATION
    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }


}
