using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public MainMenu mainmenu;
    public void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            mainmenu.LoadNextLevel();
        }
    }
}
