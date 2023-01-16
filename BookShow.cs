using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShow : MonoBehaviour
{
    public GameObject Book;
    public static bool showBook = false;

    public void OnBook()
    {
        if (showBook == false)
        {
            Book.SetActive(true);
            showBook = true;
        }
        else if (showBook == true)
        {
            Book.SetActive(false);
            showBook = false;
        }
    }
}
