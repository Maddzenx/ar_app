using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class from_qr : MonoBehaviour
{
    public Button back;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        back = root.Q<Button>("Button");
        back.clicked += backPressed;
    }

    // Update is called once per frame
    void backPressed()
    {
        SceneManager.LoadScene("Scene bookshelf");
    }

}
