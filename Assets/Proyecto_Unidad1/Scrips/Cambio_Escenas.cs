using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_Escenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)){
            int indexEscenaActual = SceneManager.GetActiveScene().buildIndex;

            switch(indexEscenaActual){
                case 0:
                    cambioEscena(1);
                    break;
                case 1:
                    cambioEscena(2);
                    break;
                case 2:
                    cambioEscena(3);
                    break;
                case 3:
                    cambioEscena(4);
                    break;  
                case 4:
                    cambioEscena(5);
                    break;
                case 5:
                    cambioEscena(0);
                    break;  
            }
        } 
    }

    void cambioEscena(int indexEscenaNueva){
        SceneManager.LoadScene(indexEscenaNueva);
    }
}
