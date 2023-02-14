using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreandhighscore : MonoBehaviour
{
    
     public Text score;
    public Text highscore;
    public Text coins;
    private double score_v;
    public static int score_int;
    public static int highscore_int;
    public static int finalcoins;
    public static int moneyfromshop;
    public static bool fading;
                
    public GameObject dino1;
    public GameObject dino2;
    public GameObject dino3;
    public GameObject dino4;
    public GameObject dino5;
    public GameObject dino6;
    public GameObject dino7;
    public GameObject dino8;
    public GameObject dino9;
    public GameObject dino10;
    public GameObject dino11;
    public GameObject dino12;
    public GameObject dino13;
    public GameObject dino14;
    
    public GameObject birds;
    public GameObject birdsdown;
    
    private bool stop1;
    private bool stop2;
    private bool stop3;
    private bool stop4;
    private bool stop5;
    private bool stop6;
    private bool stop7;
    private bool stop8;
    private bool stop9;
    private bool stop10;
    private bool stop11;
    private bool stop12;
    private bool stop13;
    private bool stop14;
    
    private int coins1;
    private int coins2;
    private int coins3;
    private int coins4;
    private int coins5;
    private int coins6;
    private int coins7;
    private int coins8;
    private int coins9;
    private int coins10;
    private int coins11;
    private int coins12;
    private int coins13;
    private int coins14;
    
    
    void start()
    {
        birds.SetActive(false);
        birdsdown.SetActive(false);
        fading = false;
        score_int = 0;
    }
    
    // Update is called once per frame
    void Update()
    {

        if (score_int % 1000 == 500)
        {
            fading = false;
        }
        else if (score_int % 1000 == 0)
        {
            fading = true;
        }
        if (score_int == 300)
        {
            birds.SetActive(true);
        }
        else if (score_int == 400)
        {
            birdsdown.SetActive(true);
        }
    
        stop1 = dino1.GetComponent<playermanagment>().isdead;
        stop2 = dino2.GetComponent<playermanagment>().isdead;
        stop3 = dino3.GetComponent<playermanagment>().isdead;
        stop4 = dino4.GetComponent<playermanagment>().isdead;
        stop5 = dino5.GetComponent<playermanagment>().isdead;
        stop6 = dino6.GetComponent<playermanagment>().isdead;
        stop7 = dino7.GetComponent<playermanagment>().isdead;
        stop8 = dino8.GetComponent<playermario>().isdead;
        stop9 = dino9.GetComponent<playercar>().isdead;
        stop10 = dino10.GetComponent<playersayian>().isdead;
        stop11 = dino11.GetComponent<playertwitter>().isdead;
        stop12 = dino12.GetComponent<playerscooter>().isdead;
        stop13 = dino13.GetComponent<playerhover>().isdead;
        stop14 = dino14.GetComponent<playermanagment>().isdead;
        coins1 = dino1.GetComponent<playermanagment>().coins;
        coins2 = dino2.GetComponent<playermanagment>().coins;
        coins3 = dino3.GetComponent<playermanagment>().coins;
        coins4 = dino4.GetComponent<playermanagment>().coins;
        coins5 = dino5.GetComponent<playermanagment>().coins;
        coins6 = dino6.GetComponent<playermanagment>().coins;
        coins7 = dino7.GetComponent<playermanagment>().coins;
        coins8 = dino8.GetComponent<playermario>().coins;
        coins9 = dino9.GetComponent<playercar>().coins;
        coins10 = dino10.GetComponent<playersayian>().coins;
        coins11 = dino11.GetComponent<playertwitter>().coins;
        coins12 = dino12.GetComponent<playerscooter>().coins;
        coins13 = dino13.GetComponent<playerhover>().coins;
        coins14 = dino14.GetComponent<playermanagment>().coins;
        
        //die false
        if (stop1 == false && stop2 == false && stop3 == false && stop4 == false && stop5 == false && stop6 == false && stop7 == false && stop8 == false && stop9 == false && stop10 == false && stop11 == false && stop12 == false && stop13 == false && stop14 == false)
        {
            score_v += 0.09;
            score_int = (int)(score_v);
            score.text = score_int.ToString();
            if (score_int > highscore_int)
            {
                highscore_int = score_int;
                highscore.text = highscore_int.ToString();
            }
            highscore.text = highscore_int.ToString();
            finalcoins = coins1 + coins2 + coins3 + coins4 + coins5 + coins6 + coins7 + coins8 + coins9 + coins10 + coins11 + coins12 + coins13 + coins14;
            coins.text = finalcoins.ToString();
        }
        
        //die true
        if (stop1 == true || stop2 == true || stop3 == true || stop4 == true || stop5 == true || stop6 == true || stop7 == true || stop8 == true || stop9 == true || stop10 == true || stop11 || stop12 || stop13 || stop14)
        {
            score_int = (int)(score_v);
            score.text = score_int.ToString();
            if (highscore_int <= score_int)
            {
                highscore_int = score_int;
                highscore.text = highscore_int.ToString();
            }
        }
    
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("highscore", highscore_int);
    }
}
