using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reborn : MonoBehaviour
{

    //Vector3 dir;
    //Ray ray;

    void Start()
    {
        //dir = new Vector3(0, -1, 0);
        //ray = new Ray(transform.position, dir);
    }

    // Update is called once per frame
    void Update()
    {

        //if(Physics.Raycast(ray, out RaycastHit hit, 20))
        //{
        //    if(hit.Equals(null))
        //    {
        //        SceneManager.LoadScene(0);
        //    }
        //}
    }


    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Obstacle"))
        {
            //gameObject.SetActive(false);
            //gameObject.transform.position = new Vector3(0, 0, 0);
            //gameObject.SetActive(true);
            SceneManager.LoadScene(3);

        }
    }



}
