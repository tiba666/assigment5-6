using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizonMove = 0f;
    bool jump = false, crouch = false;
    public Animator animate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizonMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animate.SetFloat("Speed", Mathf.Abs(horizonMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animate.SetBool("IsJumping", jump);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
  
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public void OnLanding()
    {
        animate.SetBool("IsJumping", false);
    } 
    public void OnCrouch(bool isCrouch)
    {
        animate.SetBool("IsCrouch", isCrouch);
    }

    private void FixedUpdate()
    {
        controller.Move(horizonMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
