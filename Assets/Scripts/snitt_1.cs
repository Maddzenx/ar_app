using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class snitt_1 : MonoBehaviour
{
    public Button snitt_ett;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        snitt_ett = root.Q<Button>("snitt_1");
        snitt_ett.clicked += snitt_ettPressed;
    }

    // Update is called once per frame
    void snitt_ettPressed()
    {
        SceneManager.LoadScene("cut_view");
    }

}
