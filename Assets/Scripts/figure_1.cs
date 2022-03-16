using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class figure_1 : MonoBehaviour
{
    public Button figure;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        figure = root.Q<Button>("figure_1");
        figure.clicked += figurePressed;
    }

    // Update is called once per frame
    void figurePressed()
    {
        SceneManager.LoadScene("Scene standard-view");
    }

}