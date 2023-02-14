using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shopmoving : MonoBehaviour
{
    
    private float speed = 80;
    private int turn;
    
    // Update is called once per frame
    void Update()
    {
        if (turn == 1)
        {
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                     
                     if (transform.position.x > -196  && transform.position.x < -194)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-195, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -181  && transform.position.x < -179)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-180, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -166  && transform.position.x < -164)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-165, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -151  && transform.position.x < -149)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-150, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -136  && transform.position.x < -134)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-135, transform.position.y);
                       transform.position = pos;
                    } 
                      if (transform.position.x > -121  && transform.position.x < -119)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-120, transform.position.y);
                       transform.position = pos;
                    } 
                      if (transform.position.x > -106  && transform.position.x < -104)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-105, transform.position.y);
                       transform.position = pos;
                    }
                      if (transform.position.x > -91 && transform.position.x < -89)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-90, transform.position.y);
                       transform.position = pos;
                    }
                      if (transform.position.x > -76  && transform.position.x < -74)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-75, transform.position.y);
                       transform.position = pos;
                    }
                       if (transform.position.x > -61  && transform.position.x < -59)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-60, transform.position.y);
                       transform.position = pos;
                    }
                       if (transform.position.x > -46  && transform.position.x < -44)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-45, transform.position.y);
                       transform.position = pos;
                    }
                                        if (transform.position.x > -31  && transform.position.x < -29)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-30, transform.position.y);
                       transform.position = pos;
                    }
                                        if (transform.position.x > -16  && transform.position.x < -14)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-15, transform.position.y);
                       transform.position = pos;
                    }
                                        if (transform.position.x <= -196)
                    {
                        Vector2 pos = new Vector2(-195, transform.position.y);
                       transform.position = pos;
                       
                    }

        }
        if (turn == -1)
        {
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                     
                      if (transform.position.x > -196  && transform.position.x < -194)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-195, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -181  && transform.position.x < -179)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-180, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -166  && transform.position.x < -164)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-165, transform.position.y);
                       transform.position = pos;
                    } 
                     if (transform.position.x > -151  && transform.position.x < -149)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-150, transform.position.y);
                       transform.position = pos;
                    }
                     if (transform.position.x > -136  && transform.position.x < -134)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-135, transform.position.y);
                       transform.position = pos;
                    }  
                        if (transform.position.x > -121  && transform.position.x < -119)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-120, transform.position.y);
                       transform.position = pos;
                    } 
                      if (transform.position.x > -106  && transform.position.x < -104)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-105, transform.position.y);
                       transform.position = pos;
                    }
                      if (transform.position.x > -91 && transform.position.x < -89)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-90, transform.position.y);
                       transform.position = pos;
                    }
                       if (transform.position.x > -76  && transform.position.x < -74)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-75, transform.position.y);
                       transform.position = pos;
                    }
                       if (transform.position.x > -61  && transform.position.x < -59)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-60, transform.position.y);
                       transform.position = pos;
                    }
                       if (transform.position.x > -46  && transform.position.x < -44)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-45, transform.position.y);
                       transform.position = pos;
                    }
                    if (transform.position.x > -31  && transform.position.x < -29)
                    {
                        turn = 0;
                        speed = 0;
                        Vector2 pos = new Vector2(-30, transform.position.y);
                       transform.position = pos;
                    }
                    if (transform.position.x > -16  && transform.position.x < -14)
                    {
                        turn = 0;
                        speed = 0;
                       Vector2 pos = new Vector2(-15, transform.position.y);
                       transform.position = pos;
                    }
                    if (transform.position.x >= 0)
                    {
                        Vector2 pos = new Vector2(0, transform.position.y);
                       transform.position = pos;
                       
                    }
                    
                                        
        }
    }
    
    public void right_b()
    {
        turn = 1;
        speed = 80;
    }
        public void left_b()
    {
        turn = -1;
        speed = 80;
    }

}
