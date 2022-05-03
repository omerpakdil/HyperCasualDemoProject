using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{

    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float rightLeftSpeed;
    public Animator playerAnimator;
    public Transform playerTransform;
    private new Rigidbody rigidbody;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * rightLeftSpeed * Time.deltaTime;
        //float verticalAxis = Input.GetAxis("Vertical") * rightLeftSpeed * Time.deltaTime;
        transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);
        playerAnimator.SetTrigger("run");
        playerAnimator.ResetTrigger("idle");


        if (Input.GetKey(KeyCode.A))
        {
            playerTransform.Rotate(0, -rightLeftSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.Rotate(0, rightLeftSpeed * Time.deltaTime, 0);
        }
    }



    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Platform3"))
        {
            rigidbody.AddForce(Vector3.left*7f);
        }
        if (collision.gameObject.CompareTag("Platform2"))
        {
            rigidbody.AddForce(Vector3.right*7f);
        }
    }













}
