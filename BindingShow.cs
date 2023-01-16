using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindingShow : MonoBehaviour
{
    public GameObject Binding;

    public static bool bindingShow;

    public void Update()
    {
        if (ManRune.man == true && SufferRune.suffer == true)
        {
            Binding.SetActive(true);
            ManRune.man = false;
            SufferRune.suffer = false;
            bindingShow = true;
        }
    }

}
