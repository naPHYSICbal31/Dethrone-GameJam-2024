using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _SpriteRenderer;
    [SerializeField] private Transform fallCheck;
    [SerializeField] private LayerMask heroLayer;
    void Start()
    {
        _SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (hasTouched())
        {
            changecolor();
        }
    }
    private bool hasTouched()
    {
        return Physics2D.OverlapCircle(fallCheck.position, 0.2f, heroLayer);
    }
    private void changecolor()
    {
        _SpriteRenderer.color = new Color(0.125f, 0.89f, 0.141f);
    }
}
