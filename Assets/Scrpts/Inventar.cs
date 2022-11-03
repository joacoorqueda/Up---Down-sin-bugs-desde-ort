using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
    
    public int tamaño = 0;

    public TextMeshProUGUI playersize;

    //public string scorestring = ("Tamaño: ");

    

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {

        playersize.text = "Score: " + tamaño.ToString();
            
    }
}
