using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArrowShots : MonoBehaviour
{
    public Text Sc;
    public Rigidbody thisArrow;
    public Transform bow;
    float intensity = 100000f;
    private bool shot;
    private int score = 0;
    void shoot()
    {
        bool shoot = Input.GetButtonDown("Jump");
        if (shoot)
        {
            Vector3 addition = new Vector3(intensity, 50, 0);
            thisArrow.AddForce(addition);
            shot = true;
        }
    }
    void FixedUpdate() {
        if (!shot)
        {
            Vector3 getdifpos;
            getdifpos = new Vector3(bow.position.x, bow.position.y-40, bow.position.z+1);
            thisArrow.MovePosition(getdifpos);
            shoot();
        }
     }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Respawn"))
        {
           shot = false;
           thisArrow.MovePosition(bow.position);
        }
        else if (collision.collider.CompareTag("Apple"))
        {
            score++;
            Sc.text=score+"Points";
            if (score >= 5)
            {
                Sc.text = "You Win";
            }
        }
        else if (collision.collider.CompareTag("Enemy"))
        {
            Sc.text = "You lost the arrow and the game";
        }
    }
}