using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float xPosRange = 100;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObjects", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomObjects()
    {
        float randXPos = Random.Range(0, xPosRange);
        int objectPrefabIndex = Random.Range(0, objectPrefabs.Length);
        Vector3 randPos = new Vector3(0, randXPos, 100);
        Instantiate(objectPrefabs[objectPrefabIndex], randPos, objectPrefabs[objectPrefabIndex].transform.rotation);
    }
}