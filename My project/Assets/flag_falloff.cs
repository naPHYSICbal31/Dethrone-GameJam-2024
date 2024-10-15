using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag_falloff : MonoBehaviour
{
    [SerializeField] private Transform toolCheck1;
    [SerializeField] private Transform toolCheck2;
    [SerializeField] private Transform toolCheck3;
    [SerializeField] private LayerMask toolLayer;
    void Start()
    {

    }


    void Update()
    {
        if (toolUsed())
        {
           
        }
    }
    private bool toolUsed()
    {
        bool x = Physics2D.OverlapCircle(toolCheck1.position, 0.2f, toolLayer) || Physics2D.OverlapCircle(toolCheck2.position, 0.2f, toolLayer) || Physics2D.OverlapCircle(toolCheck3.position, 0.2f, toolLayer);
        return x;
    }
   
}
