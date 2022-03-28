using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class maskinelement : MonoBehaviour

{
        public Button Maskin;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        Maskin = root.Q<Button>("maskinelement");
        Maskin.clicked += MaskinPressed;
        
    }

    // Update is called once per frame
    void MaskinPressed()
    {
        SceneManager.LoadScene("categories");
    }
}
