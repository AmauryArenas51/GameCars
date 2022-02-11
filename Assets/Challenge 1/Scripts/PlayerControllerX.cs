using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //PROPIEDADES / CAMPOS
    //[HideInInspector]

    [Range(0, 100), SerializeField, Tooltip("Velocidad lineal máxima del coche")]
    private float speed = 15f;

    [Range(0, 100), SerializeField, Tooltip("Velocidad de giro del coche")]
    private float rotationSpeed = 100f;

    private float horizontalInput, verticalInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontalInput);
    }

}

/*//PROPIEDADES / CAMPOS
//[HideInInspector]

[Range(0, 100), SerializeField, Tooltip("Velocidad lineal máxima del coche")]
private float speed = 20f;

[Range(0, 100), SerializeField, Tooltip("Velocidad de giro del coche")]
private float turnSpeed = 50f;

private float horizontalInput, verticalInput, spaceInput;

private Rigidbody rb;

public GameObject propeller;

private float rotation = 4000;

// Start is called before the first frame update
void Start()
{
    rb = GetComponent<Rigidbody>();
    propeller = GetComponent<GameObject>();
}

// Update is called once per frame
void Update()
{
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");
    spaceInput = Input.GetAxis("Jump");

    // Tenemos que mover el vehículo hacia adelante
    // S = s0 + V*t*(dirección)

    if (spaceInput > 0)
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward * spaceInput);
        rb.useGravity = false;
        propeller.transform.Rotate(rotation * Time.deltaTime * Vector3.forward);
    }
    else
    {
        rb.useGravity = true;
    }

    transform.Rotate(turnSpeed * Time.deltaTime * Vector3.left * verticalInput);
    transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
}*/