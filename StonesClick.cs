using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesClick : MonoBehaviour
{
    public static bool stonesClick;

    public GameObject SmallStone;


    public void Update()
    {
        if (stonesClick == true)
        {
            SmallStone.SetActive(true);
            stonesClick = false;
        }
    }
    private void OnMouseDown()
    {
        stonesClick = true;
    }
}
