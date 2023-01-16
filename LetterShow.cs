using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterShow : MonoBehaviour
{
    public GameObject Let;
    public static bool showLetter;


    public void OnMouseDown()
    {
        if (showLetter == false)
        {
            Let.SetActive(true);
            showLetter = true;
        }
        else if (showLetter == true)
        {
            Let.SetActive(false);
            showLetter = false;
        }
    }
}
