using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{
    public void Drag(float value)
    {
        Debug.Log($"Slider value: {value}");
    }
}
