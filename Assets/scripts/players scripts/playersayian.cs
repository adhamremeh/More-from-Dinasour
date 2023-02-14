﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playersayian : MonoBehaviour
{
    public string[] hops = new string[]{"hop1", "hop2", "hop3"};
   
    public GameObject up;
    public GameObject down;
    public GameObject b_up;
    public GameObject playerdie;
    public bool grounded = false;
    public bool down_condition = false;
    public bool isdead = false;
    
    private Animator anim_;
    
    public float jumpforce = 5f;
    
    public int coins = 0;
    private int death;
 
    private void Start()
    {
        anim_ = GetComponent<Animator>();
        up.SetActive(true);
        down.SetActive(false);
    }
    
 
    private void Update()
    {
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
            death++;
            if (death == 1)
            {
                FindObjectOfType<Audiomanager>().playsound("death");
            }
            this.GetComponent<SpriteRenderer>().enabled = false;
            anim_.enabled = false;
        }
        if (grounded == true && down_condition == true)
        {
                up.SetActive(false);
                down.SetActive(true);
        }
    }  
     
     
    public void jump_d()   
    {
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
        down_condition = true;
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -jumpforce - 2), ForceMode2D.Impulse);
        anim_.SetBool("down", true);
    }
        public void down_u()
    {
        down_condition = false;
        anim_.SetBool("down", false);
        up.SetActive(true);
        down.SetActive(false);
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
          grounded = false;
          anim_.SetBool("jump", true);
        }        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coins"))
        {
             coins++;
        }
    }

    public void Dead()
    {
        isdead = true;
    }

}
