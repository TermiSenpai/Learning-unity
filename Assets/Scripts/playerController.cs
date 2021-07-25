using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float movementSpeed = 10.0f;
    public float rangoX = 20.0f;
    public GameObject proyectilPrefab;
    public GameObject cookie;

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(proyectilPrefab, transform.position, proyectilPrefab.transform.rotation);
        }
        if(Input.GetKeyUp(KeyCode.Return))
        {
            Instantiate(cookie, transform.position, cookie.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        float horizontalMovement = horizontalInput * Time.deltaTime * movementSpeed;

        //mover al jugador horizontalmente
        transform.Translate(Vector3.right * horizontalMovement);

        //limites del jugador
        limitX();
    }


    void limitX()
    {
        //Comprueba el limite del jugador en el rago X

        if (transform.position.x < -rangoX) transform.position = new Vector3(-rangoX, transform.position.y, transform.position.z);

        if (transform.position.x > rangoX) transform.position = new Vector3(rangoX, transform.position.y, transform.position.z);
    }

}