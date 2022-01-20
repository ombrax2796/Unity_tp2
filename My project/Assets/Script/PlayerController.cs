using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable 

    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    public float speed = 10;
    public float jumpIntensity = 3;

    public bool IsGrounded;
    public bool CanDoubleJump;

    public Transform GroundCheckL;
    public Transform GroundCheckR;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Jump et animation

        IsGrounded = Physics2D.OverlapArea(GroundCheckL.position, GroundCheckR.position);

        if(IsGrounded){

            animator.SetBool("IsJump", false);

        }else{

            animator.SetBool("IsJump", true);

        }
        
        if(Input.GetButtonDown("Jump") && IsGrounded){

            rb.AddForce(Vector2.up * jumpIntensity, ForceMode2D.Impulse);

            CanDoubleJump = true;

        }
        else if (Input.GetButtonDown("Jump") && CanDoubleJump){

            rb.AddForce(Vector2.up * jumpIntensity, ForceMode2D.Impulse);

            CanDoubleJump = false;

        }

    }

}
