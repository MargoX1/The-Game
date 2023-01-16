using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushClick : MonoBehaviour
{
    public static bool brushClick;

    public void OnBrush()
    {
        brushClick = true;
    }
}
