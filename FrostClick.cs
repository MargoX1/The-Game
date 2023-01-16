using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostClick : MonoBehaviour
{
    public static bool frostClick;

    public void OnMouseDown()
    {
        frostClick = true;
    }
}
