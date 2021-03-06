using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnX = 19;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 1.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
    }
    void SpawnRandomAnimal()
    {
        float randomXspawn = Random.Range(-SpawnX, SpawnX);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randPos = new Vector3(randomXspawn, 0, 21);
        Instantiate(animalPrefabs[animalPrefabIndex], randPos,
            animalPrefabs[animalPrefabIndex].transform.rotation); ;
    }
}
