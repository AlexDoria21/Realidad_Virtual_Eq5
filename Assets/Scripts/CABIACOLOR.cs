using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CABIACOLOR : MonoBehaviour
{
    Renderer rend; 

    [SerializeField]
    Color col;

    
    // Start is called before the first frame update
    void Start()
    {
        col = Color.red;
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
    rend.material.color=Color.grey;
    }
}
