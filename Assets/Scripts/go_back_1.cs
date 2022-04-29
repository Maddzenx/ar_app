using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class go_back_1 : MonoBehaviour
{
    public Button back_1;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        back_1 = root.Q<Button>("go_back_1");
        back_1.clicked += back_1Pressed;
    }

    // Update is called once per frame
    void back_1Pressed()
    {
        SceneManager.LoadScene("categories");
    }

}
