using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playertwitter : MonoBehaviour
{
    public string[] hops = new string[]{"hop1", "hop2", "hop3"};
    public string[] coins_s = new string[] { "coins1", "coins2", "coins3" };

    public GameObject b_up;
    public GameObject b_down;
    public GameObject playerdie;
    public bool grounded = false;
    public bool isdead = false;

    public float jumpforce = 5f;
    
    public int coins = 0;
    private int doublejump;
    private int death;

    private Animator anim;
    
        public Rigidbody2D rb;
    
    private void Start()
    {
        playerdie.SetActive(false);
        anim = GetComponent<Animator>();
        anim.SetTrigger("twi");
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll_up = b_up.GetComponent<Collider2D>();
            Collider2D coll_down= b_down.GetComponent<Collider2D>();
            if (coll_up.OverlapPoint(wp))
            {
                jump_d();
            }
            if (coll_down.OverlapPoint(wp))
            {
                down_d();
            }
        }
        
        if (isdead == true)
        {
            playerdie.SetActive(true);
            this.GetComponent<SpriteRenderer>().enabled = false;
            death++;
            if (death == 1)
            {
                FindObjectOfType<Audiomanager>().playsound("death");
            }
        }
    }  
     
     
    public void jump_d()   
    {
        if (doublejump >= 1)
        {
            string p_hops = hops[Random.Range (0, hops.Length)];
            FindObjectOfType<Audiomanager>().playsound(p_hops);
            rb.velocity = Vector2.up * jumpforce;
            doublejump -= 1;
        }
    }
    public void down_d()   
    {
        if (grounded == false)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -30), ForceMode2D.Impulse);
        }
    }
    
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
          grounded = true;
          doublejump = 2;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground")
        {
          grounded = false;
        }        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coins"))
        {
             string p_coins = coins_s[Random.Range(0, coins_s.Length)];
             FindObjectOfType<Audiomanager>().playsound(p_coins);
             coins++;
        }
    }

    public void Dead()
    {
        isdead = true;
    }
}
