using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleLoggerScript : MonoBehaviour
{
    public bool LogError = false;
    public bool LogException = false;
    private int msgNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"This is message {msgNumber++}");
        Debug.LogWarning("This is a warning...");
    }

    // Update is called once per frame
    void Update()
    {
        if (LogError)
            Debug.LogError("This is an error!");
        if (LogException)
            Debug.LogException(new System.Exception("This is an EXCEPTION!!"));
        Debug.Log($"This is message {msgNumber++}");
    }
}
