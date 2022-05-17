using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class rem_list : MonoBehaviour
{
    public Button start;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        start = root.Q<Button>("button_4");
        start.clicked += startPressed;
    }

    // Update is called once per frame
    void startPressed()
    {
        SceneManager.LoadScene("rem_list");
    }

}