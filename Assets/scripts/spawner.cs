using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
        public GameObject[] obs;
        public float timebtwspawn;
        public float starttimebtwspawn;
        public float decreasetime;
        public float mintime = 0.65f;
        
    void start()
    {
        float startrand = Random.Range(3f, 4f);
        starttimebtwspawn = startrand;
    }

    void Update()
    {
            float randx = Random.Range(17f, 45f);
            transform.position = new Vector2(randx, transform.position.y);
        if (timebtwspawn <= 0)
        {
            int rand = Random.Range(0, obs.Length);
            if (rand == 1)
            {
                Instantiate(obs[1], transform.position, Quaternion.identity);
            }
            else if (rand == 0)
            {
                Instantiate(obs[0], transform.position, Quaternion.identity);
            }
            else if (rand == 2)
            {
                Instantiate(obs[2], transform.position, Quaternion.identity);
            }
            else if (rand == 3)
            {
                Instantiate(obs[3], transform.position, Quaternion.identity);
            }
            else if (rand == 4)
            {
                Instantiate(obs[4], new Vector3(transform.position.x, -2.57f, transform.position.z), Quaternion.identity);
            }
            timebtwspawn = starttimebtwspawn;
            if (starttimebtwspawn > mintime)
            {
                starttimebtwspawn -= decreasetime;    
            }
        }
        else if (timebtwspawn <= 10)
        {
            timebtwspawn -= Time.deltaTime;
        }

    }
}
