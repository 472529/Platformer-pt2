using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public GameObject Player;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            Destroy(gameObject);
        }
    }
}
