using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playermario : MonoBehaviour
{
    public string[] hops = new string[]{"hop1", "hop2", "hop3"};
   
    public GameObject up;
    public GameObject down;
    public GameObject b_up;
    public GameObject playerdie;
    public GameObject mariosmall;
    public GameObject clear;
    public bool grounded = false;
    public bool down_condition = false;
    public bool isdead = false;
    
    private bool caninc = false;
    private bool candec = false;
    
    private Animator anim_;
    
    public float jumpforce = 5f;
    
    public int coins = 0;
    private int death;
    
    private float t_m = 0f;
    
    public bool mario_b;
 
    private void Start()
    {
        anim_ = GetComponent<Animator>();
        up.SetActive(true);
        down.SetActive(false);
    }
    
 
    private void Update()
    {
        if (mario_b == true)
        {
            t_m = 4;
            mariosmall.tag = "mariobig";
            up.tag = "mariobig";
            down.tag = "mariobig";
            if (caninc == true)
            {
                anim_.Play("incmario");
                caninc = false;
            }
            anim_.SetBool("inc", true);
            StartCoroutine(waitmario(t_m));
        }
        else
        {
            clear.tag = "Untagged";
            anim_.SetBool("inc", false);
            if (candec == true)
            {
                StartCoroutine(waitdec(t_m));
                up.SetActive(true);
                down.SetActive(false);
            }
            
            
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Collider2D coll_up = b_up.GetComponent<Collider2D>();
                if (coll_up.OverlapPoint(wp))
                {
                    jump_d();
                }
            }
            if (isdead == false)
            {
                playerdie.SetActive(false);
            }
            else if (isdead == true)
            {
                playerdie.SetActive(true);
                up.SetActive(false);
                down.SetActive(false);
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                death++;
                if (death == 1)
                {
                    FindObjectOfType<Audiomanager>().playsound("death");
                }
                anim_.enabled = false;
            }
            if (grounded == true && down_condition == true)
            {
                    up.SetActive(false);
                    down.SetActive(true);
            }
        }
    }  
     
     
    public void jump_d()   
    {
        anim_.SetBool("onetime", false);
        if (grounded == true)
        {
            string p_hops = hops[Random.Range (0, hops.Length)];
            FindObjectOfType<Audiomanager>().playsound(p_hops);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        }
        up.SetActive(true);
        down.SetActive(false);
    }
    public void down_d()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -jumpforce - 2), ForceMode2D.Impulse);
        down_condition = true;
        if (mario_b == true)
        {

        }
        else
        {
            anim_.SetBool("down", true);
            anim_.SetBool("onetime", false);
        }
    }
        public void down_u()
    {
        down_condition = false;
        if (mario_b == true)
        {
            
        }
        else
        {
            anim_.SetBool("down", false);
            up.SetActive(true);
            down.SetActive(false);
        }
    }
    
    IEnumerator waitdec(float sec)
    {
        if (sec == 0)
        {
            yield return new WaitForSeconds(sec);
            mariosmall.tag = "Player";
            up.tag = "Player";
            down.tag = "Player";
            anim_.SetBool("onetime", true);
            clear.tag = "spawndestroy";
            candec = false;
            t_m = 0;
        }
    }
    IEnumerator waitmario(float sec)
    {
         if (sec == 4)
        {
            yield return new WaitForSeconds(sec);
            mario_b = false;
            candec = true;
            t_m = 0;
        }
    }
    
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
          grounded = true;
          anim_.SetBool("jump", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
          
          if (mario_b == false)
          {
            grounded = false;
            anim_.SetBool("jump", true);
          }
          else
          {
            grounded = true;
            anim_.SetBool("jump", false);    
          }
        }
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (mario_b == true){
            if (other.CompareTag("coins"))
            {
                 coins++;
            }
        }
        else
        {
            if (other.CompareTag("coins"))
            {
                 coins++;
            }
            if (other.CompareTag("mario"))
            {
                caninc = true;
                mario_b = true;
            }
        }
     }

    public void Dead()
    {
        isdead = true;
    }

}
