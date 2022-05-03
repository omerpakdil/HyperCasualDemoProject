using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter2 : MonoBehaviour
{

    public new Rigidbody rigidbody;
    private float wSpeed;
    private float rlSpeed;
    public Animator animator;
    public Transform playerTransform;


    void Start()
    {
        wSpeed = 3f;
        rlSpeed = 240f;
    }

    // Update is called once per frame
    void Update()
    {    
         MoveChar();     
    }


    void MoveChar()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("run");
            animator.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.ResetTrigger("run");
            animator.SetTrigger("idle");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("runback");
            animator.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.ResetTrigger("runback");
            animator.SetTrigger("idle");
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerTransform.Rotate(0, -rlSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.Rotate(0, rlSpeed * Time.deltaTime, 0);
        }


        float MoveAxis = Input.GetAxis("Vertical");
        float RotateAxis = Input.GetAxis("Horizontal");
        rigidbody.MovePosition(transform.position + transform.forward * Time.deltaTime * wSpeed * MoveAxis);
        //rigidbody.MoveRotation(transform.rotation * Quaternion.Euler(transform.up*RotateAxis*rlSpeed*Time.deltaTime));
    }


    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            rigidbody.AddForce(Vector3.left * 7f);
        }
    }

    void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("Platform"))
            this.transform.parent = null;
    }






}
