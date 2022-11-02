using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoTamaño : MonoBehaviour
{
    Shot planelife;
    // Start is called before the first frame update
    void Start()
    {

        planelife = GameObject.FindGameObjectWithTag("Player").GetComponent<Shot>();
        
        
        //transform.localScale = new Vector3(x: 1f, y: 1f, z: 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Token"))
        {
            
         transform.localScale += new Vector3(x:0.05f, y: 0f, z: 0.05f);


            planelife.VidaAvioneta = planelife.VidaAvioneta + 1;

            //quiero que cuando dispares te haga un poco mas chico
        }
    }
}
