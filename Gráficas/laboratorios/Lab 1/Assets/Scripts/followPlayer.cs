using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <summary>
// Clase que controla la camara para seguir al jugador
// Standard Coding Documentation can be found at:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
// </summary>

public class followPlayer : MonoBehaviour
{
    // <summary>
    // Variable global para el jugador
    // </summary>
    public GameObject player;

    // <summary>
    // Variable global para la distancia entre la camara y el jugador
    // </summary>
    private Vector3 offset = new Vector3(0,5,-7);
    // Start is called before the first frame update

    // <summary>
    // Metodo que se llama antes de la primera actualizacion de frames
    // </summary>
    void Start()
    {
        
    }

    // <summary>
    // Metodo que actualiza la posicion de la camara despues de la actualizacion de frames
    // </summary>
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
