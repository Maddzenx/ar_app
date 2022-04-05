using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]
public class backToVR : MonoBehaviour
{
    public Button tillbaka;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        try
        {
            string a = null;
            a.ToString();
        }
        catch (NullReferenceException e)
        {
            //Code to do something with e
            tillbaka = root.Q<Button>("AR_toggle");
            tillbaka.clicked += tillbakaPressed;
        }

    }

    // Update is called once per frame
    void tillbakaPressed()
    {
        SceneManager.LoadScene("LA_3D");
    }
}

