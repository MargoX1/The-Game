using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneShow : MonoBehaviour
{
    public static bool stoneShow;

    private void OnMouseDown()
    {
        stoneShow = true;
    }
}
