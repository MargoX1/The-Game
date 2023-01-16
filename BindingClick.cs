using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindingClick : MonoBehaviour
{
    public static bool bindingClick;
    
    public void OnMouseDown()
    {
        bindingClick = true;
    }
}
