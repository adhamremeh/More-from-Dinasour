using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birds : MonoBehaviour
{
    public GameObject bird;
    public GameObject colliderda;
    public bool obstcal = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obstcal == true)
        {
            bird.transform.position = new Vector2(transform.position.x + 5, 0);
            colliderda.SetActive(false);
            obstcal = false;
        }

    }
    
        void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("spawndestroy"))
        {
            Destroy(gameObject);
        }
        
    }
}
