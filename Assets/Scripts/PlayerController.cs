using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
        The purpuse of this class is The movement of the player
     */
    private float speed = 25;
    public float xMovement;
    public float zMovement;
    public bool isGrounded;
    public float yMovement;
    
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        /*Abstraction for movement
         * 
         *  zMovement = Input.GetAxis("Vertical") * speed;
            rbPlayer.AddForce(Vector3.forward * zMovement);
            
         *  xMovement = Input.GetAxis("Horizontal") * speed;
            rbPlayer.AddForce(Vector3.right * xMovement);
                
         */

        PlayerZMovement();
        PlayerXMovement();
        PlayerJump();

    }

    private void PlayerZMovement()
    {
        zMovement = Input.GetAxis("Vertical") * speed;
        rbPlayer.AddForce(Vector3.forward * zMovement);
    }

    private void PlayerXMovement()
    {
        xMovement = Input.GetAxis("Horizontal") * speed;
        rbPlayer.AddForce(Vector3.right * xMovement);
    }
    private void PlayerJump() 
    {
        yMovement = Input.GetAxis("Jump") * jumpForce;
        if (isGrounded)
        {
            rbPlayer.AddForce(Vector3.up * yMovement, ForceMode.Impulse);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            speed = 25;
            
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
            speed = 12;
            
        }
    }
}
