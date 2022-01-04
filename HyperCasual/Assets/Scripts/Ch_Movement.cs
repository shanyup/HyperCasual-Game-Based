using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Ch_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Animator anim;
    public Transform groundCheckPos;
    public LayerMask groundLayer;

    public Transform[] Layers;
    private int layerInt;
    private GameManager _GameManager;
    private Ch_Stats _ChStats;

    public bool onMid, onRight, onLeft;
    void Start()
    {
        onMid = true;
        onRight = false;
        onLeft = false;
        _GameManager = FindObjectOfType<GameManager>();
        _ChStats = FindObjectOfType<Ch_Stats>();
    }

    private void Update()
    {
        if (_GameManager.isGameStart)
        {
            ChangeLine();
            if (SwipeManager.swipeUp)
            {
                Jump();
            }
        }

        
    }

    void FixedUpdate()
    {
        if (_GameManager.isGameStart)
        {
            Run();
        }
    }

    private void Run()
    {
        rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,_ChStats.movementSpeed);
    }

    private void Jump()
    {
        rb.AddForce(new Vector3(0,_ChStats.jumpSpeed * 350,0));
    }

    private void ChangeLine()
    {
        if (SwipeManager.swipeRight && onMid)
        {
            transform.position = new Vector3(Layers[2].position.x,transform.position.y,transform.position.z);
            onMid = false;
            onRight = true;
            onLeft = false;
        }

        if (SwipeManager.swipeRight && onLeft)
        {
            transform.position = new Vector3(Layers[1].position.x,transform.position.y,transform.position.z);
            onMid = true;
            onRight = false;
            onLeft = false;
        }
        if (SwipeManager.swipeLeft && onMid)
        {
            transform.position = new Vector3(Layers[0].position.x,transform.position.y,transform.position.z);
            onMid = false;
            onRight = false;
            onLeft = true;
        }
        if (SwipeManager.swipeLeft && onRight)
        {
            transform.position = new Vector3(Layers[1].position.x,transform.position.y,transform.position.z);
            onMid = true;
            onRight = false;
            onLeft = false;
        }
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(groundCheckPos.position, 0.1f, groundLayer);
    }
}
