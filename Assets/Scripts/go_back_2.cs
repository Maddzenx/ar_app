using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class go_back_2 : MonoBehaviour
{
    public Button back_2;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        back_2 = root.Q<Button>("go_back_2");
        back_2.clicked += back_2Pressed;
    }

    // Update is called once per frame
    void back_2Pressed()
    {
        SceneManager.LoadScene("Scene bookshelf");
    }

}
