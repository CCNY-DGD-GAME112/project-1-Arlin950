using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb;
    private float xInput;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
// Update is called once per frame
    void Update()
    {
        float moveSpeed = 6f;
        
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x,jumpForce);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-moveSpeed,rb.linearVelocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(moveSpeed,rb.linearVelocity.y);
        }

    }
}