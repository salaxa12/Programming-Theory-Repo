using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CubeScript : Shape
{
    private float width;
    private float height;
    private float length;

    //INHERITANCE
    public CubeScript(string color, float length, float width, float height)
    {
        this.color = color;
        this.length = length;
        this.height = height;
        this.width = width;
    }

    //POLYMORPHISM
    public string displayText()
    {
        return "I am a cube";
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

    public float getWidth()
    {
        return width;
    }

    public void setWidth(float width)
    {
        this.width = width;
    }

    public float getLength()
    {
        return length;
    }

    public void setLength(float length)
    {
        this.length = length;
    }
}
