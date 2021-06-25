using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public string name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadMainScene()
    {
        name = nameInput.text;
        SceneManager.LoadScene("Main Scene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
