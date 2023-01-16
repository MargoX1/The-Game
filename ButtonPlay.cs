using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{

    public void OnPlay()
    {

        ButtonPause.pause = false;
        ButtonPause.ispuse = false;
    }
}
