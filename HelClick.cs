using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelClick : MonoBehaviour
{
    public static bool helClick;

    public void OnMouseDown()
    {
        helClick = true;
    }
}
