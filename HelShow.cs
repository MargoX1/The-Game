using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelShow : MonoBehaviour
{
    public GameObject Hel;
    public static bool helShow;

    public void Update()
    {
        if (DeadManRune.deadMan == true && HelRune.hel == true)
        {
            Hel.SetActive(true);
            helShow = true;
            DeadManRune.deadMan = false;
            HelRune.hel = true;
        }
    }
}
