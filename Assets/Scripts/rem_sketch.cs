using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class rem_sketch : MonoBehaviour
{
   public Button sketch;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        sketch = root.Q<Button>("sketch_view");
        sketch.clicked += sketchPressed;
    }

    // Update is called once per frame
    void sketchPressed()
    {
        SceneManager.LoadScene("rem_sketch");
    }
}