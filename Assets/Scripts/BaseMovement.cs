using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseMovement : MonoBehaviour
{
    public float BaseForceMultiplier = 10.0f;
    public bool usePhysics;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 value)
    {

        if (usePhysics)
        {
            rb.AddForce(value * BaseForceMultiplier);
        }
        else
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            rb.MovePosition(pos + value);
        }
    }
}
