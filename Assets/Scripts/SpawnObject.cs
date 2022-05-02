using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float xPosRange = 13;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject",3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomObject()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int objectPrefabIndex = Random.Range(0, objectPrefabs.Length);
        Vector3 randPos = new Vector3 (randXPos, 0, 21);
        Instantiate(objectPrefabs[objectPrefabIndex], randPos, objectPrefabs[objectPrefabIndex].transform.rotation);
    }
}
