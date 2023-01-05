using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PukkiMovement03 : MonoBehaviour
{
    // define variables
    public float speed;
    public Rigidbody2D rb;
    public Animator anim;

    private AudioSource axeSwing;
    private float attackTime = .40f;
    private float attackCounter = .40f;
    private bool isAttacking;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        axeSwing = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Input for movement
        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            anim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }

        // Input for player attack
        if (Input.GetKeyDown(KeyCode.T))
        {
            axeSwing.Play();
            attackCounter = attackTime;
            anim.SetBool("isAttacking", true);
            isAttacking = true;
        }
    }

    void FixedUpdate()
    {
        // Movement
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.fixedDeltaTime;

        anim.SetFloat("moveX", rb.velocity.x);
        anim.SetFloat("moveY", rb.velocity.y);

        // if our declared bool isAttacking on Animator is true we want to our player to play anim and stop while doing it
        if (isAttacking)
        {
            rb.velocity = Vector2.zero;

            attackCounter -= Time.fixedDeltaTime;
            if (attackCounter <= 0)
            {
                anim.SetBool("isAttacking", false);
                isAttacking = false;
            }
        }
    }
}
