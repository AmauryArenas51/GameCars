using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //PROPIEDADES / CAMPOS
    //[HideInInspector]

    [Range(0, 20), SerializeField, Tooltip("Velocidad lineal máxima del coche")]
    private float speed = 10f;

    [Range(0, 90), SerializeField, Tooltip("Velocidad de giro del coche")]
    private float turnSpeed = 45f;

    private float horizontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Tenemos que moverT el vehículo hacia adelante
        // S = s0 + V*t*(dirección)

        transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
