using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float runSpeed;
    public float jumpSpeed;
    private Rigidbody2D myrigidbody;
    private Animator myAnim;
    private BoxCollider2D myFeet;
    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        myAnim= GetComponent<Animator>();
        myFeet= GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
        Run();
        Jump();
        CheckGrounded();
    }
    void CheckGrounded()
    {
        isGround = myFeet.IsTouchingLayers(LayerMask.GetMask("Ground"));
        Debug.Log(isGround);
    }
    void Flip()
    {
        bool playerHasXAxisSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
        if(playerHasXAxisSpeed)
        {
            if(myrigidbody.velocity.x> 0.1f) 
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if (myrigidbody.velocity.x < -0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }
    void Run () 
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 plauerVel = new Vector2(moveDir * runSpeed, myrigidbody .velocity.y);
        myrigidbody.velocity = plauerVel;
        bool playerHasXAxisSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
        myAnim.SetBool("Run", playerHasXAxisSpeed);
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(isGround)
            {
                Vector2 jumpVel = new Vector2(0.0f, jumpSpeed);
                myrigidbody.velocity = Vector2.up * jumpVel;
            }
        }
    }

}
 