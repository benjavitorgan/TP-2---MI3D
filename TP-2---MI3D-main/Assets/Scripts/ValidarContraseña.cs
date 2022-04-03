using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string ContraseniaCorrecta;
    string ContraseniaUsuario;
    public Text IngresoUsuario;
    public Text textomsj;
    public GameObject cartelitoMsj;

    // Start is called before the first frame update
    void Start()
    {
        ContraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidarContrasenia()
    {
        ContraseniaUsuario = IngresoUsuario.text;

        if (ContraseniaUsuario == ContraseniaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log ("Bienvenido");
        } else
        {
            cartelitoMsj.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
 