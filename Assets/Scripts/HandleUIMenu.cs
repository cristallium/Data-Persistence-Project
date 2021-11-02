using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleUIMenu : MonoBehaviour
{

    TMP_InputField nameInput;

    // Start is called before the first frame update
    void Awake()
    {
        nameInput = GameObject.Find("NameInput").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicPlay()
    {
        GameManager.Instance.setPlayName(nameInput.text);
        GameManager.Instance.startGame();
    }
}
