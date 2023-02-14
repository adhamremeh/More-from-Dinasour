using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusDestroyer : MonoBehaviour
{

    public GameObject cactus;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("obstcals"))
        {
            Destroy(cactus);
        }

    }
}
