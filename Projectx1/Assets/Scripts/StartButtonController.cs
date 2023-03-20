using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{

    void Start()
    {
        // Get the button component on this GameObject
        Button button = GetComponent<Button>();

        // Add an onClick event listener to the button
        button.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // Deactivate this button GameObject
        gameObject.SetActive(false);
    }
}

