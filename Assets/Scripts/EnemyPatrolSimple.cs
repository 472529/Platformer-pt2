using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolSimple : MonoBehaviour
{
    public float speed;
    public float distance;
    public Animator anim;

    Player player;

    public bool movingRight = true;

    public Transform groundDetection;
    void Update()
    {

        if (anim.GetBool("IsDead") == true)
        {
          
        }
        else
        {
            RayGroundChecker();
        }
        

        
    }

    void RayGroundChecker()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            anim.SetBool("IsDead", true);
            gameObject.layer = LayerMask.NameToLayer("Default");
            transform.gameObject.tag = "Untagged";
            Destroy(gameObject, 5);
        }
    }
}
