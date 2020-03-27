using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitaleSpielekiste;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    [Header("UI")]
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        AddHooks();

        NetworkController.Initialize();
    }

    void AddHooks() {
        NetworkController.onInitialized += OnInitialized;
    }

    void OnInitialized() {
        Debug.Log($"Succesfully Initialized.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
