using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Damage : MonoBehaviour
{
    public int Damage;
    public int speed;
    public float lifeTime;
    
    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        var V = other.GetComponent<Shot>();
        if(V)
        {
            V.VidaAvioneta -= Damage;
            Destroy(gameObject);

            
        }
    }
}