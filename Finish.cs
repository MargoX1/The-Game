using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject End;
    
    public void Endgame()
    {
        End.SetActive(true);
    }
}
