using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLeft : MonoBehaviour
{
    public float Speed = 1f;

    private void OnCollisionEnter(Collision coll)
        {
        coll.transform.parent = transform;
        }
    private void OnCollisionExit(Collision coll)
    {
        coll.transform.parent = null;
    }

    void FixedUpdate()
    {
        if (transform.position.x > 33)
        {
            Speed = -Speed;
        }
        if (transform.position.x < 41)
        {
            Speed = -Speed;
        }
        Vector3 input = new Vector3(1, 0, 0);
        transform.position = transform.position + input * Time.deltaTime * Speed;
    }
}
