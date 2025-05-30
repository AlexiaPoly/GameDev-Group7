using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcwalk : MonoBehaviour {
    public float speed = 2f;
    public Rigidbody2D rb;
    public LayerMask groundLayers;
    public Transform groundCheck;

    bool isFacingLeft = true;

    RaycastHit2D hit;

    private void Update() {
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);
    }

    private void FixedUpdate() {
        if (hit.collider != false) {
            if (isFacingLeft) {
              rb.linearVelocity = new Vector2(speed,rb.linearVelocity.y); 
            } else {
              rb.linearVelocity = new Vector2(-speed,rb.linearVelocity.y);   
            }
        } else {
            isFacingLeft = !isFacingLeft;
            transform.localScale = new Vector3(-transform.localScale.x, 1f, 1f);
        }
    }
    
}

