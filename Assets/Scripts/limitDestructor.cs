using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitDestructor : MonoBehaviour
{
    float limitUp = 30;
    float limitDown = -14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limitUp || transform.position.z < limitDown)
        {
            Destroy(gameObject);
        }
    }
}
