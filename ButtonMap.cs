using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMap : MonoBehaviour
{
    public static bool ispuse;
    public GameObject Map;

    void Update()
    {
        if (ispuse == true)
        {
            Map.SetActive(true);
        }
        else if (ispuse == false)
        {
            Map.SetActive(false);
        }
    }

    public void OnMap()
    {
        if (ispuse == false)
        {
            ispuse = true;
        }
        else if (ispuse == true)
        {
            ispuse = false;
        }
    }

}
