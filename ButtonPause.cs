using UnityEngine;
using System.Collections;
public class ButtonPause: MonoBehaviour
{
    public float timer; 
    public static bool ispuse; 
    public bool guipuse;
    public static bool pause;
    public GameObject Menu;
    
    void Update()
    {
        Time.timeScale = timer; 
        if ((Input.GetKeyDown(KeyCode.Escape) || pause == true) && ispuse == false) 
        { 
            ispuse = true; 
        } 
        else if (Input.GetKeyDown(KeyCode.Escape) && ispuse == true) 
        { 
            ispuse = false; 
        }
        if (ispuse == true) 
        { 
            timer = 0; 
            guipuse = true; 
        }
        else if (ispuse == false)
        {
            timer = 1f; 
            guipuse = false;
        } 
    } 
    
    public void OnPause()
    {
        pause = true;
    }


    public void OnGUI() 
    { 
        if (guipuse == true) 
        {
            Menu.SetActive(true);
        } 
        else if (guipuse == false)
        {
            Menu.SetActive(false);
            pause = false;

        }
    } 
}

