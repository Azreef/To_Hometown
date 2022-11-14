using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public PlayerMovement player;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(-(player.speed/2) * Time.fixedDeltaTime, 0);
    }
}
