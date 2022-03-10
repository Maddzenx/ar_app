using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class NextScript : MonoBehaviour
{
    public Button info;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        info = root.Q<Button>("info_button");
        info.clicked += infoPressed;
    
    }

    // Update is called once per frame
    void infoPressed() {
        SceneManager.LoadScene("Scene standard-view");
        
    }


}