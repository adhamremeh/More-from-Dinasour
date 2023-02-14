using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public float speed ;
    public bool obstcal = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreandhighscore.score_int % 100 == 50)
        {
            speed = speed + (float)(0.07);
        }
        if (speed >= 27)
        {
            speed = 27;
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (obstcal == true)
        {
            transform.position = new Vector2(transform.position.x, 0.6900001f);
        }
    }
    
        void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("spawndestroy"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("obstcals"))
        {
            obstcal = true;
        }
        if (other.CompareTag("mariobig"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("notbirds"))
        {
            Destroy(gameObject);
        }
        
    }
}
