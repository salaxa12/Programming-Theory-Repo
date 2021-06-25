using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereDemo : MonoBehaviour
{
    public TMP_Text displayText;
    private string sphereColor;
    private Vector3 sphereScale;
    public Material shapeMaterial;

    SphereScript sphere = new SphereScript("red", 1.0f);

    // Start is called before the first frame update
    void Start()
    {
        
        sphereColor = sphere.getColor();
        sphereScale =  new Vector3(sphere.getRadius(), sphere.getRadius(), sphere.getRadius());

        transform.localScale = sphereScale;
    }

    private void OnMouseDown()
    {
        displayText.text = sphere.displayText();
        shapeMaterial.SetColor("_Color", Color.red);
    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
