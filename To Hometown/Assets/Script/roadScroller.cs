using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class roadScroller : MonoBehaviour
{
    public PlayerMovement player;


    void FixedUpdate()
    {
        transform.position += new Vector3(-player.speed * Time.fixedDeltaTime, 0);

        if(transform.position.x < -10.59)
        {
            transform.position = new Vector3(11.90f, transform.position.y);
        }

    }

}
