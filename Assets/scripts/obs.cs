using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obs : MonoBehaviour
{
        public float speed ;
        public GameObject dead;
        public bool die;
      
        void start()
        {
            dead.SetActive(false);
        }
        
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

        if (die)
        {
            if (playerselector.classic || playerselector.red || playerselector.yellow || playerselector.blue || playerselector.Sports || playerselector.pumpkin || playerselector.engineer || playerselector.luffy)
            {
                FindObjectOfType<playermanagment>().Dead();
            }
            else if (playerselector.car)
            {
                FindObjectOfType<playercar>().Dead();
            }
            else if (playerselector.twitter)
            {
                FindObjectOfType<playertwitter>().Dead();
            }
            else if (playerselector.scooter)
            {
                FindObjectOfType<playerscooter>().Dead();
            }
            else if (playerselector.hover)
            {
                FindObjectOfType<playerhover>().Dead();
            }
            else if (playerselector.mario)
            {
                FindObjectOfType<playermario>().Dead();
            }
            else if (playerselector.sayian)
            {
                FindObjectOfType<playersayian>().Dead();
            }
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dead.SetActive(true);
            Time.timeScale = 0;
            die = true;
        }

        if (other.CompareTag("spawndestroy"))
        {
            Destroy(gameObject);
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
