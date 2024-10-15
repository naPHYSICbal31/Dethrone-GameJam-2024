using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform fallCheck;
    [SerializeField] private LayerMask heroLayer;
    private void FixedUpdate()
    {
        if(hasTouched())
        {
            falldown();
        }
    }
    private bool hasTouched()
    {
        return Physics2D.OverlapCircle(fallCheck.position, 0.2f, heroLayer);
    }
    private void falldown()
    {
        rb.gravityScale = 4f;
    }
}
