using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public GroundManager groundie;
    public Rigidbody2D riggity;
    public bool CanJump;
    public float JumpForce;
    private bool Jumping;
    private Vector2 move;
    public float JumpTime;
    public float JumpActual;
    private bool facingRight;
    public Animator animator;
    public Manager Manager;

    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Manager>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            Manager.Mask.targetSize = 20;
            Manager.Mask.TargetScene = "MainMenu";
            Manager.Mask.shrinking = true;
        }
        animator.SetBool("OnGround", CanJump);
        
        if(groundie.CanJump){
            CanJump = true;
            JumpActual = JumpTime;
        }else{
            CanJump = false;
        }
        
        if(CanJump && Input.GetButtonDown("Jump")){
            Jumping = true;
        }
        else if(Input.GetButton("Jump") && JumpActual > 0){
            Jumping = true;
            JumpActual -= Time.deltaTime;
        }else{
            Jumping = false;
            JumpActual = 0;

        }
        if(Input.GetButtonUp("Jump")){
            JumpActual = 0;
        }
        
        if(Input.GetAxis("Horizontal") > 0 && !facingRight || Input.GetAxis("Horizontal") < 0 && facingRight){
            facingRight = !facingRight;
            Vector3 theScale = player.transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;

        }
        animator.SetFloat("HorizontalSpeed", Mathf.Abs(Input.GetAxis("Horizontal") * speed));
        
        animator.SetBool("Jumping", Jumping);
    }
    
    void FixedUpdate(){
        if(Jumping){
            move = new Vector2(Input.GetAxis("Horizontal") * speed, JumpForce);
        }else{
            move = new Vector2(Input.GetAxis("Horizontal") * speed, riggity.velocity.y);
        }

        
        //Debug.Log(move);
        riggity.velocity = move;
    }
    
}
