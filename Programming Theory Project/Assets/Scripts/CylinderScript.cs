using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : Shape
{
    private float radius;
    private float height;

    //INHERITANCE
    public CylinderScript(string color, float radius, float height)
    {
        this.color = color;
        this.radius = radius;
        this.height = height;
    }

    //POLYMORPHISM
    public string displayText()
    {
        return "I am a Cylinder";
    }


    // ENCAPSULATION
    public float getHeight()
    {
        return height;
    }

    public void setHeight(float height)
    {
        this.height = height;
    }

    public float getRadius()
    {
        return radius;
    }

    public void setRadius(float radius)
    {
        this.radius = radius;
    }
}
