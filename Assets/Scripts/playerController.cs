using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float movementSpeed = 10.0f;
    public float rangoX = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //mover al jugador horizontalmente
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);
        //Mover al jugador verticalmente
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * movementSpeed);

        //limites del jugador
        limitX();
        limitZ();
    }


    void limitX()
    {
        //Comprueba el limite del jugador en el rago X

        if (transform.position.x < -rangoX) transform.position = new Vector3(-rangoX, transform.position.y, transform.position.z);

        if (transform.position.x > rangoX) transform.position = new Vector3(rangoX, transform.position.y, transform.position.z);
    }
    
    void limitZ()
    {
        //Comprueba el limite del jugador en el rago X

        if (transform.position.z < -14) transform.position = new Vector3(transform.position.x, transform.position.y, -14);

        if (transform.position.z > 30) transform.position = new Vector3(transform.position.x, transform.position.y, 30);
    }
}
