using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]
public class Add_book : MonoBehaviour

{
        public Button Add;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        Add = root.Q<Button>("add_book");
        Add.clicked += AddPressed;
        
    }

    // Update is called once per frame
    void AddPressed()
    {
        SceneManager.LoadScene("cut_view");
    }
}
