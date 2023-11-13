using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 10;
    private Rigidbody2D rb;
    private Vector2 direction;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");

            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
            animator.SetFloat("Speed", direction.sqrMagnitude);
    }

    void FixedUpdate()
    {
        direction = direction.normalized * Speed;
        rb.velocity = direction;
    }
}
