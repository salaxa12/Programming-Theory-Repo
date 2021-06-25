using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class SphereScript : Shape
{
    private float radius;

    //INHERITANCE
    public SphereScript(string color, float radius)
    {
        this.color = color;
        this.radius = radius;
    }

    //POLYMORPHISM
    public string displayText()
    {
        return "I am a sphere";
    }


    // ENCAPSULATION
    public float getRadius()
    {
        return radius;
    }

    public void setRadius(float radius)
    {
        this.radius = radius;
    }
}
