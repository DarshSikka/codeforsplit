using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    [SerializeField]
    void move()
    {

        float l_r = Input.GetAxisRaw("Horizontal");
        float u_d = Input.GetAxisRaw("Vertical");
        if (l_r != 0)
        {
            Vector3 pos = transform.position;
            pos.z += l_r;
            transform.position = pos;
        }
        else if (u_d != 0)
        {
            Vector3 pos = transform.position;
            pos.y += u_d;
            transform.position = pos;
        }
    }
    void FixedUpdate()
    {
        move();
    }
}
