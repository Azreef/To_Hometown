using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class roadScroller : MonoBehaviour
{
    [SerializeField]
    private float roadSpeed = 10;
    
    void FixedUpdate()
    {
        transform.position += new Vector3(-roadSpeed * Time.fixedDeltaTime, 0);

        if(transform.position.x < -14.17)
        {
            transform.position = new Vector3(14.13f, transform.position.y);
        }

    }

}
