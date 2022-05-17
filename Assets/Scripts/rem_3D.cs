using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class rem_3D : MonoBehaviour
{
    public Button restart;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        restart = root.Q<Button>("button");
        restart.clicked += restartPressed;
    }

    // Update is called once per frame
    void restartPressed()
    {
        SceneManager.LoadScene("rem_view");
    }

}