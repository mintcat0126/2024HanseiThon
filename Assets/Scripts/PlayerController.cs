using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 inputVec;

    private float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        var newInputVec = inputVec * speed * Time.deltaTime;
        rb.MovePosition(rb.position + newInputVec);
    }

    private void HandleInput()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
    }


}
