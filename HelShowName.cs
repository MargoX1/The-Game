using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelShowName : MonoBehaviour
{
    public GameObject HelName;

    public static bool showHelName;

    public void Update()
    {
        if (HelShow.helShow == true && iRune.i == true && nRune.n == true && rRune.r == true && vRune.v == true)
        {
            HelName.SetActive(true);

            showHelName = true;
        }
    }
}
