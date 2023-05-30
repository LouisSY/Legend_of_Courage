using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCheck : MonoBehaviour
{
    [Header("Detection Parameters")]
    public Vector2 bottomOffset;
    public float checkRadius;
    public LayerMask groundLayer;
    
    [Header("Statement")]
    public bool isGround;
    private void Update()
    {
        Check();
    }

    public void Check()
    {
        // check the ground
        isGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, checkRadius, groundLayer);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere((Vector2)transform.position + bottomOffset, checkRadius);
    }
}
