using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CylinderDemo : MonoBehaviour
{
    public TMP_Text displayText;
    private string cylinderColor;
    private Vector3 cylinderScale;
    public Material shapeMaterial;

    CylinderScript cylinder = new CylinderScript("yellow", 1, 1);

    // Start is called before the first frame update
    void Start()
    {

        cylinderColor = cylinder.getColor();
        cylinderScale = new Vector3(cylinder.getRadius(), cylinder.getHeight(), cylinder.getRadius());

        transform.localScale = cylinderScale;
    }

    private void OnMouseDown()
    {
        displayText.text = cylinder.displayText();
        shapeMaterial.SetColor("_Color", Color.yellow);
    }


    // Update is called once per frame
    void Update()
    {

    }


}
