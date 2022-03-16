using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class loading_screen : MonoBehaviour
{
    public Button click;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        click = root.Q<Button>("click");
        click.clicked += clickPressed;
    }

    // Update is called once per frame
    void clickPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
