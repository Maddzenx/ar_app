using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class off_rem_cut : MonoBehaviour
{
    public Button cut;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        cut = root.Q<Button>("cut_view");
        cut.clicked += cutPressed;
    }

    // Update is called once per frame
    void cutPressed()
    {
        SceneManager.LoadScene("rem_view");
    }

}