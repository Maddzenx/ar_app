using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class off_explosion : MonoBehaviour
{
    public Button Exp;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        Exp = root.Q<Button>("explosion_view");
        Exp.clicked += ExpPressed;
    }

    // Update is called once per frame
    void ExpPressed()
    {
        SceneManager.LoadScene("LA_3D");
    }

}
