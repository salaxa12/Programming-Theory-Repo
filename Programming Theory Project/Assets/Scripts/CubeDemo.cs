using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeDemo : MonoBehaviour
{
    public TMP_Text displayText;
    private string cubeColor;
    private Vector3 cubeScale;
    public Material shapeMaterial;

    CubeScript cube = new CubeScript("green", 1.0f, 1.0f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
        
        cubeColor = cube.getColor();
        cubeScale = new Vector3(cube.getLength(), cube.getWidth(), cube.getHeight());

        transform.localScale = cubeScale;
    }

    private void OnMouseDown()
    {
        displayText.text = cube.displayText();
        shapeMaterial.SetColor("_Color", Color.green);
    }


    // Update is called once per frame
    void Update()
    {

    }


}
