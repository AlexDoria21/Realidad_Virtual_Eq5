using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.W)){
        Debug.Log("Adelante");
    }
    if (Input.GetKey(KeyCode.S)){
        Debug.Log("Atras"); 
    }
    if (Input.GetKey(KeyCode.A)){
        Debug.Log("Izquierda");
    }
    if (Input.GetKey(KeyCode.D)){
        Debug.Log("Derecha");
    } 
    }
}
