using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class animation_view : MonoBehaviour
{
    public Button Animation;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
    
        Animation = root.Q<Button>("animation_view");
        Animation.clicked += AnimationPressed;
    }

    // Update is called once per frame
    void AnimationPressed()
    {
        SceneManager.LoadScene("animation_view");
    }

}