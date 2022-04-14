using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "ThirdPersonController")
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            Destroy(gameObject);
            
        }
    }
}
