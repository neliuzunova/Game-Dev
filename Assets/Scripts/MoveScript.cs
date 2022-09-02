using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour{
    private Rigidbody2D rb;
    public Transform player;
    public float jumpForce;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundlayer;
    public Animator animator;
    public GameObject bulletPrefab;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){


        animator.SetFloat("Speed", 0);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
        if(isGrounded)
        {
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }
        groundCheck.transform.localPosition = new Vector3(0, -0.79f, 0);
        if (Input.GetKey("d")){
            animator.SetFloat("Speed", 1);
            transform.Translate(4 * Time.deltaTime, 0,0);
        }
        if (Input.GetKey("a")){
            animator.SetFloat("Speed", 1);
            transform.Translate(-4 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("w") && isGrounded)
        {
            //transform.Translate(0, 50 * Time.deltaTime, 0);
           // animator.SetBool("IsJumping", true);
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKeyDown("space"))
        {
            //transform.Translate(0, 50 * Time.deltaTime, 0);
            // animator.SetBool("IsJumping", true);
            
            shootBullet();
        }

    }
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;


    }
}
