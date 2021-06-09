using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TheApple : MonoBehaviour
{
    public Rigidbody apple;
    public Animator anim;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Huh");
            Vector3 cur = transform.position;
            cur.y -= 50;
            apple.MovePosition(cur);
            apple.AddForce(transform.up*-100f);
            anim.SetBool("falling", true);
        }
    }
}
