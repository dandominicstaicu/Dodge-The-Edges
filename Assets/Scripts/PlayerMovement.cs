using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;


    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator.SetBool("Grav", false);
    }
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }
        if (Input.GetButtonDown("Reset"))
        {
            Application.LoadLevel(PlayerPrefs.GetInt("lastLevel"));

        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        if (Input.GetButtonDown("GravityUp"))
        {
            animator.SetBool("Grav", true);
            rb2d.gravityScale = -3;
            SoundManagerScript.PlaySound("sus");
        }
        if (Input.GetButtonDown("GravityDown"))
        {
            rb2d.gravityScale = 3;
            animator.SetBool("Grav", false);
            SoundManagerScript.PlaySound("jos");
        }

    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}