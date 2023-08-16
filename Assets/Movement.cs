using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool inFacingRight = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private  int Health;
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(Health <=0)
        {
            return;
        }
        
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed,rb.velocity.y);

    }
    

    void takeDam(int damage)
    {
        Health -= damage;
    }

}
