using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentControl : MonoBehaviour
{

    public Animator playerAnimator;
    private float distance;
    private int randomMoveSpeed;
    public Transform girlCenter;
    Vector3 edgePosition;
    private float timeCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RaycastHit hit;

        if ((timeCounter += Time.deltaTime) > 0.5f)
        {
            randomMoveSpeed = Random.Range(10,50);


            if (Physics.Raycast(girlCenter.position, girlCenter.TransformDirection(Vector3.forward), out hit, 6f))
            {

                //while (Physics.Raycast(girlCenter.position, girlCenter.TransformDirection(Vector3.forward), out hit, 4f))
                //{
                //    while(girlCenter.position.x < 2 && girlCenter.position.x > -2)
                //    {
                //        transform.Translate(new Vector3(-1, 0, 0) * randomMoveSpeed * Time.deltaTime);
                //    }
                //}

                if (girlCenter.position.x > 0)
                {
                    transform.Translate(new Vector3(-1, 0, 0) * randomMoveSpeed * Time.deltaTime);
                }
                else
                {
                    transform.Translate(new Vector3(1, 0, 0) * randomMoveSpeed * Time.deltaTime);
                }


                Debug.DrawRay(girlCenter.position, girlCenter.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                Debug.Log("Hedefi Vurduk");
            }
            else
            {
                Debug.DrawRay(girlCenter.position, girlCenter.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                Debug.Log("Hedefi Iskaladık");
            }

            timeCounter = 0;

        }



        transform.Translate(transform.forward * Time.deltaTime * 2f);
        playerAnimator.SetTrigger("run");
        playerAnimator.ResetTrigger("idle");
    }
}
