using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
        void OnCollisionEnter(Collision collision)
        {
        Destroy(gameObject);
        }
    }
