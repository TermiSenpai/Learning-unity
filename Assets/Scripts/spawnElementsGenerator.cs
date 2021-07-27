using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnElementsGenerator : MonoBehaviour
{
    public GameObject[] animalArray;
    public int indexAnimal;
    public int spawnPositionZ;
    public int spawnPositionX;

    float waitStart = 2.0f;
    float waitGeneration = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animalPositionGenerator", waitStart, waitGeneration);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void animalPositionGenerator()
    {
        indexAnimal = Random.Range(0, animalArray.Length);
        spawnPositionX = randomPosGenerator(-15, 15);
        spawnPositionZ = randomPosGenerator(29, 15);
        Vector3 positionGenerator = new Vector3(spawnPositionX, 0, spawnPositionZ);

        Instantiate(animalArray[indexAnimal], positionGenerator, animalArray[indexAnimal].transform.rotation);
    }
    
    int randomPosGenerator(int min, int max)
    {
        return Random.Range(min, max);
    }

}
