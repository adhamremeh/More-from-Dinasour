using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reapeat : MonoBehaviour
{
    public float speed;
    
    public float endx;
    public float startx;
    
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
        
        if (transform.position.x <= endx)
        {
            Vector2 pos = new Vector2(startx, transform.position.y);
            transform.position = pos;
        }
        
    }
}
