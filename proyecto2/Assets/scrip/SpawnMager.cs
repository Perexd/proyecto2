using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnMager : MonoBehaviour
{
   private float xRange = 15f;
   private float spawnZ = 25f;
   private float startTime = 2f;
   private float repeatRate = 1.5f;
   private int randomIndex;

    public GameObject[] animalPrefabs;
    private Vector3 spawnPotition = new Vector3 (0, 0, 25);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startTime, repeatRate);
    }

    // Update is called once per frame
   
   
    public Vector3 RandomPosition()
    {
        float randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, spawnZ);
    }

    public void SpawnAnimal()
    {
     randomIndex = Random.Range(0, animalPrefabs.Length);
     spawnPotition = RandomPosition();
        Instantiate(animalPrefabs[randomIndex], spawnPotition, 
            animalPrefabs[randomIndex].transform.rotation);
    }

} 
