using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{
    public int EdadUsuario;

    // Start is called before the first frame update
    void Start()
    {
        EdadUsuario = 19;

        if (EdadUsuario >= 18)
        {
            Debug.Log("Es mayor de edad");
        } else
        {
            Debug.Log("No es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
