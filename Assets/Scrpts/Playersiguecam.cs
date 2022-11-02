using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playersiguecam : MonoBehaviour
{
    Camera cam;
    Collider planecollider;
    RaycastHit hit;
    Ray ray;


    void Start()
    {
        cam = Camera.main;
        planecollider = GameObject.Find("Plane").GetComponent<Collider>();
    }


    void Update()
    {
        // transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));

        //if (Input.GetMouseButton(1))
        //{

        
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.collider != planecollider)
            {


                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * 5);
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }

        }


    }
}
//}