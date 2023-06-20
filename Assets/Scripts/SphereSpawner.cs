using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSphere", 1, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSphere() {
        Vector3 spawnPos = new Vector3(-0.226f, 78.94f, 48.334f);
        Instantiate(sphere, spawnPos, Quaternion.identity);
    }
}
