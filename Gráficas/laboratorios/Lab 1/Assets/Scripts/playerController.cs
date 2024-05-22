using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <summary>
// Clase que controla el movimiento del autobus
// Standard Coding Documentation can be found at: 
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
// </summary>

public class PlayerController : MonoBehaviour
{
    // <summary>
    // Variables para multijuagdor
    // </summary>
    public string inputId;

    // <summary>
    // Variable global para la velocidad del autobus
    // </summary>
    public float speed = 5.0f;

    // <summary>
    // Variable global para girar el autobus
    // </summary>
    public float turnSpeed = 0.0f;

    // <summary>
    // Variable global para girar con teclado 
    // </summary>
    public float horizontalInput;

    // <summary>
    // Variable global para avanzar con teclado
    // </summary>
    public float forwardInput;
    // Start is called before the first frame update

    // <summary>
    // Metodo que se llama antes de la primera actualizacion de frames
    // </summary>

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    void Start()
    {
        
    }

    // <summary>
    // Metodo que actualiza la posicion del autobus despues de la actualizacion de frames
    // </summary>
    void Update()
    {
        // <summary>
        // Obtener la entrada del teclado
        // </summary>
        horizontalInput = Input.GetAxis("Horizontal" + inputId);
        forwardInput = Input.GetAxis("Vertical" + inputId);

        // <summary>
        // Mover autobus hacia adelante
        // </summary>

        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);   

        // <summary>
        // Girar autobus
        // </summary>
        
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // <summary>
        // Cambiar camara
        // </summary>
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}
