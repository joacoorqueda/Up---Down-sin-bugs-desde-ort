using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Avion : MonoBehaviour
{
    public int VidaAvionn = 0;

    private void Update()
    {
        if (VidaAvionn <= 0)
        {
            Destroy(gameObject);
            
        }

    }
}
