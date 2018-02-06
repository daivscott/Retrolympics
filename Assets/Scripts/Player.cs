using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;

    public float moveSpeed;
    public float jumpSpeed;
    public static bool isMoving;

    private Animator anim;

    private bool grounded;
    private bool leftFoot;
    private bool jump;

    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundDistance;

    // Use this for initialization
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();             
    }

    // Update is called once per frame
    void Update()
    {
        // Check for key being pressed
        if (Input.GetKeyDown(KeyCode.A) && (!isMoving))
        {
            // Check to allow alternate footsteps
            if (leftFoot==false)
            {
                // Move player
                myRigidbody2D.velocity = new Vector2(moveSpeed, myRigidbody2D.velocity.y);
                leftFoot = true; // reset flag
            }
            
        }

        // Check for key being pressed
        if (Input.GetKeyDown(KeyCode.D) && (!isMoving))
        {
            // Check to allow alternate footsteps
            if (leftFoot == true)
            {
                // Move player on X axis
                myRigidbody2D.velocity = new Vector2(moveSpeed, myRigidbody2D.velocity.y);
                leftFoot = false; // reset flag
            }
            
        }
        
        // Set animation float variable from player movement
        anim.SetFloat("speed", Mathf.Abs(myRigidbody2D.velocity.x));

        // Check for key being pressed
        if (Input.GetKeyDown(KeyCode.Space) && (!isMoving))
        {
            // Check if already jumping
            if (jump == false)
            {
                // Move player on X axis
                myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpSpeed);
            }
        }
        
        // Sets grounded boolean
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, whatIsGround);
        anim.SetBool("jump", !grounded);
        jump = !grounded;

        

    }

public static void Moving()
        {
            isMoving = !isMoving;
        }
    
}