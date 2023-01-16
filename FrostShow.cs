using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostShow : MonoBehaviour
{
    public GameObject Frost;

    public static bool showFrost;

    public void Update()
    {
        if (YearRune.year == true && HelRune.hel == true)
        {
            Frost.SetActive(true);
            YearRune.year = true;
            HelRune.hel = true;
            showFrost = true;
        }
    }
}
