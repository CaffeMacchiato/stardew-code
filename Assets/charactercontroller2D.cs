using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class charactercontroller2D : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;
    Animator animator;
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    } 

    void Update()
    {
        motionVector = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw ("Vertical")
            );
        animator.SetFloat("horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("vertical",  Input.GetAxisRaw("Vertical"));
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        rigidbody2d.velocity = motionVector * speed;
    }
}