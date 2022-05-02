using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody enemyRB;
    GameObject player;
    public float speed = 4.0f;

    private float yBoundary = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yBoundary || transform.position.y > yBoundary)
        {
            Destroy(gameObject);
        }
    }
}
