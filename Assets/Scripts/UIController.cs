using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button Testknappen;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        Testknappen = root.Q<Button>("Testknapp");
        Testknappen.clicked += TestknappenPressed;
    }

    // Update is called once per frame
    void TestknappenPressed() {
        SceneManager.LoadScene("New Scene");

    }
}