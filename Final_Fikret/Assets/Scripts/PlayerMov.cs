using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private CharacterController cc;
    public float speed = 5f;
    public float gravity = -20f;
    public float jumpspeed = 15f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    Vector3 moveVelocity;
    Vector3 turnVelocity;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.Move(move * Time.deltaTime * speed);

       
        
            if (Input.GetButtonDown("Jump") )
            {
            Jump();
            }
        
        
        moveVelocity.y += gravity * Time.deltaTime;
        cc.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);

    }
    void Jump()
    {
        moveVelocity.y = jumpspeed;
    }
    

}
 