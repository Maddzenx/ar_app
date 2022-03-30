using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class kullager : MonoBehaviour
{
    public Button kul;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        kul = root.Q<Button>("kullager");
        kul.clicked += kulPressed;
    }

    // Update is called once per frame
    void kulPressed()
    {
        SceneManager.LoadScene("list_of_elements");
    }

}
