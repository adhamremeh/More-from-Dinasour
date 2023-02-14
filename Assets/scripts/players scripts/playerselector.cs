using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerselector : MonoBehaviour
{
    public GameObject classic_p;
    public GameObject red_p;
    public GameObject yellow_p;
    public GameObject blue_p;
    public GameObject Sports_p;
    public GameObject pumpkin_p;
    public GameObject twitter_p;
    public GameObject scooter_p;
    public GameObject hover_p;
    public GameObject car_p;
    public GameObject engineer_p;
    public GameObject mario_p;
    public GameObject luffy_p;
    public GameObject sayian_p;
    
    public GameObject mariospawner;
    
    public static bool classic;
    public static bool red;
    public static bool yellow;
    public static bool blue;
    public static bool Sports;
    public static bool pumpkin;
    public static bool twitter;
    public static bool scooter;
    public static bool hover;
    public static bool car;
    public static bool engineer;
    public static bool mario;
    public static bool luffy;
    public static bool sayian;
    
    void Start()
    {
        mariospawner.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        classic = shop.selected_c;
        red = shop.selected_r;
        yellow = shop.selected_y;
        blue = shop.selected_b;
        Sports = shop.selected_Sports;
        pumpkin = shop.selected_pumpkin;
        twitter = shop.selected_twitter;
        scooter = shop.selected_scooter;
        hover = shop.selected_hover;
        car = shop.selected_car;
        engineer = shop.selected_engineer;
        mario = shop.selected_mario;
        luffy = shop.selected_luffy;
        sayian = shop.selected_sayian;
        
        if (classic == true)
        {
            classic_p.SetActive(true);
        }
        else
        {
            classic_p.SetActive(false);
        }
        
        if (red == true)
        {
            red_p.SetActive(true);
        }
        else
        {
            red_p.SetActive(false);
        }
        
        if (yellow == true)
        {
            yellow_p.SetActive(true);
        }
        else
        {
            yellow_p.SetActive(false);
        }
        
        if (blue == true)
        {
            blue_p.SetActive(true);
        }
        else
        {
            blue_p.SetActive(false);
        }
           
        if (Sports == true)
        {
            Sports_p.SetActive(true);
        }
        else
        {
            Sports_p.SetActive(false);
        }
        if (pumpkin == true)
        {
            pumpkin_p.SetActive(true);
        }
        else
        {
            pumpkin_p.SetActive(false);
        }
        if (twitter == true)
        {
            twitter_p.SetActive(true);
        }
        else
        {
            twitter_p.SetActive(false);
        }
        if (scooter == true)
        {
            scooter_p.SetActive(true);
        }
        else
        {
            scooter_p.SetActive(false);
        }
        if (hover == true)
        {
            hover_p.SetActive(true);
        }
        else
        {
            hover_p.SetActive(false);
        }
        if (car == true)
        {
            car_p.SetActive(true);
        }
        else
        {
            car_p.SetActive(false);
        }
        if (engineer == true)
        {
            engineer_p.SetActive(true);
        }
        else
        {
            engineer_p.SetActive(false);
        }
        if (mario == true)
        {
            mario_p.SetActive(true);
            mariospawner.SetActive(true);
        }
        else
        {
            mariospawner.SetActive(false);
            mario_p.SetActive(false);
        }
        if (luffy == true)
        {
            luffy_p.SetActive(true);
        }
        else
        {
            luffy_p.SetActive(false);
        }
        if (sayian == true)
        {
            sayian_p.SetActive(true);
        }
        else
        {
            sayian_p.SetActive(false);
        }
        
    }
    
}
