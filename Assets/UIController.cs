using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
public Button Testknapp;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        Testknapp = root.Q<Button>("Testknapp");


    }

    // Update is called once per frame
    void TestknappPressed() {
        SceneManager.LoadScene("Scene bookshelf");

    }
}