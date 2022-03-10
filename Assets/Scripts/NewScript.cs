using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class NewScript : MonoBehaviour
{
    public Button testknapp;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        testknapp = root.Q<Button>("info_button");
        testknapp.clicked += testknappPressed;
    }

    // Update is called once per frame
    void testknappPressed() {
        SceneManager.LoadScene("infobox_view");

    }

}
