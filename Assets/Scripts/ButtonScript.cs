using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void Click ()
    {
        Debug.Log($"{gameObject.GetComponentInChildren<Text>().text} clicked!");
    }
}
