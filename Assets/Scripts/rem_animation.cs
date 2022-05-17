using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UIDocument))]

public class rem_animation : MonoBehaviour
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
        SceneManager.LoadScene("rem_animation");
    }

}