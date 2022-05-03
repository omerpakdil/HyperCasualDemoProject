using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{


    public Animator playerAnimator;
    public Rigidbody playerRigid;
    public float wSpeed, sSpeed,rSpeed;
    public Transform playerTransform;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRigid.velocity = transform.forward * wSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.velocity = -transform.forward * sSpeed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnimator.SetTrigger("run");
            playerAnimator.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnimator.ResetTrigger("run");
            playerAnimator.SetTrigger("idle");
            playerRigid.velocity = transform.forward * 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnimator.SetTrigger("runback");
            playerAnimator.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.ResetTrigger("runback");
            playerAnimator.SetTrigger("idle");
            playerRigid.velocity = transform.forward * 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerTransform.Rotate(0, -rSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.Rotate(0, rSpeed * Time.deltaTime, 0);
        }

       
    }
}
