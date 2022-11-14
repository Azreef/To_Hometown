using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float playerSpeed = 5f;

    public Rigidbody2D rb;

    private Vector2 movement;


    public int speed;

    void Start()
    {
        speed = 10;
    }


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (speed + 5 < 30)
        {
             if (Input.GetKeyDown("x"))
            {
                speed = speed + 5;
            }
        }

        if (speed - 5 > 0)
        {
            if (Input.GetKeyDown("z"))
            {
                speed = speed - 5;
            }
        }

 



    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * playerSpeed * Time.fixedDeltaTime);

    }
}
