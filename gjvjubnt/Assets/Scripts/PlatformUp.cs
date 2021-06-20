using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{
    public float Speed = 0.8f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 1)
        {
            Speed = -Speed;
        }
        if (transform.position.y < 4)
        { 
            Speed = -Speed;
        }
        Vector3 input = new Vector3(0, 1, 0);
        transform.position = transform.position + input * Time.deltaTime * Speed;
    }
}
