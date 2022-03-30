using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class ar_toggle : MonoBehaviour

{
        public Button ArToggle;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        ArToggle = root.Q<Button>("VR_toggle");
        ArToggle.clicked += ArTogglePressed;
        
    }

    // Update is called once per frame
    void ArTogglePressed()
    {
        SceneManager.LoadScene("BasicARScene");
    }
}
