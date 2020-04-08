using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputMessageController : MonoBehaviour
{

    public Text outputMessageText;
    public string message;

    // Start is called before the first frame update
    void Start()
    {
        message = "";
    }

    // Update is called once per frame
    void Update()
    {
        outputMessageText.text = message;
    }
}
