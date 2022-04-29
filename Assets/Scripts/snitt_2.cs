using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class snitt_2 : MonoBehaviour
{
    public Button snitt_tva;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        snitt_tva = root.Q<Button>("snitt_2");
        snitt_tva.clicked += snitt_tvaPressed;
    }

    // Update is called once per frame
    void snitt_tvaPressed()
    {
        SceneManager.LoadScene("cut_view_2");
    }

}