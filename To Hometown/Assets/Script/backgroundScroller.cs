using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroller : MonoBehaviour
{
    [SerializeField]
    private float backgroundSpeed = 0.1f;

    void FixedUpdate()
    {
        transform.position += new Vector3(-backgroundSpeed * Time.fixedDeltaTime, 0);
    }
}
