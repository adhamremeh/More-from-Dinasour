using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    //sprites
        public GameObject p_c;
    public GameObject p_r;
    public GameObject p_y;
    public GameObject p_b;
    public GameObject p_Sports;
    public GameObject p_pumpkin;
    public GameObject p_twitter;
    public GameObject p_scooter;
    public GameObject p_hover;
    public GameObject p_car;
    public GameObject p_engineer;
    public GameObject p_mario;
    public GameObject p_luffy;
    public GameObject p_sayian;
        public GameObject s_c;
    public GameObject s_r;
    public GameObject s_y;
    public GameObject s_b;
    public GameObject s_Sports;
    public GameObject s_pumpkin;
    public GameObject s_twitter;
    public GameObject s_scooter;
    public GameObject s_hover;
    public GameObject s_car;
    public GameObject s_engineer;
    public GameObject s_mario;
    public GameObject s_luffy;
    public GameObject s_sayian;
        public GameObject sed_c;
    public GameObject sed_r;
    public GameObject sed_y;
    public GameObject sed_b;
    public GameObject sed_Sports;
    public GameObject sed_pumpkin;
    public GameObject sed_twitter;
    public GameObject sed_scooter;
    public GameObject sed_hover;
    public GameObject sed_car;
    public GameObject sed_engineer;
    public GameObject sed_mario;
    public GameObject sed_luffy;
    public GameObject sed_sayian;
    
    public Text coins;
    
    public static bool purchased_c;
    public static bool purchased_r;
    public static bool purchased_y;
    public static bool purchased_b;
    public static bool purchased_Sports;
    public static bool purchased_pumpkin;
    public static bool purchased_twitter;
    public static bool purchased_scooter;
    public static bool purchased_hover;
    public static bool purchased_car;
    public static bool purchased_engineer;
    public static bool purchased_mario;
    public static bool purchased_luffy;
    public static bool purchased_sayian;
    public static bool selected_c = true;
    public static bool selected_r;
    public static bool selected_y;
    public static bool selected_b;
    public static bool selected_Sports;
    public static bool selected_pumpkin;
    public static bool selected_twitter;
    public static bool selected_scooter;
    public static bool selected_hover;
    public static bool selected_car;
    public static bool selected_engineer;
    public static bool selected_mario;
    public static bool selected_luffy;
    public static bool selected_sayian;
    
    public static int moneyshop;
    public static int money = 5000;

    public static int c_int;
    public static int r_int;
    public static int y_int;
    public static int b_int;
    public static int S_int;
    public static int p_int;
    public static int sc_int;
    public static int t_int;
    public static int h_int;
    public static int car_int;
    public static int e_int;
    public static int m_int;
    public static int l_int;
    public static int sayian_int;

    public static int selector = 1;
    
    public int ret;
    public int men;
    // Start is called before the first frame update
    void Awake()
    {
        ret = retry.inte;

       if (ret == 1)
       {
         moneyshop = scoreandhighscore.finalcoins; 
         money = moneyshop + money;  
       }
       else
       {
         moneyshop = 0;
         money = moneyshop + money;
       }
        PlayerPrefs.SetInt("money", money);
        v_p_c();
    }

    void Start()
    {
       v_s_c(); ;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        coins.text = money.ToString();
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D coll_c = p_c.GetComponent<Collider2D>();
            Collider2D coll_r = p_r.GetComponent<Collider2D>();
            Collider2D coll_y = p_y.GetComponent<Collider2D>();
            Collider2D coll_b = p_b.GetComponent<Collider2D>();
            Collider2D coll_Sports = p_Sports.GetComponent<Collider2D>();
            Collider2D coll_pumpkin = p_pumpkin.GetComponent<Collider2D>();
            Collider2D coll_twitter = p_twitter.GetComponent<Collider2D>();
            Collider2D coll_scooter = p_scooter.GetComponent<Collider2D>();
            Collider2D coll_hover = p_hover.GetComponent<Collider2D>();
            Collider2D coll_car = p_car.GetComponent<Collider2D>();
            Collider2D coll_engineer = p_engineer.GetComponent<Collider2D>();
            Collider2D coll_mario = p_mario.GetComponent<Collider2D>();
            Collider2D coll_luffy = p_luffy.GetComponent<Collider2D>();
            Collider2D coll_sayian = p_sayian.GetComponent<Collider2D>();
            Collider2D coll_c_s = s_c.GetComponent<Collider2D>();
            Collider2D coll_r_s = s_r.GetComponent<Collider2D>();
            Collider2D coll_y_s = s_y.GetComponent<Collider2D>();
            Collider2D coll_b_s = s_b.GetComponent<Collider2D>();
            Collider2D coll_Sports_s = s_Sports.GetComponent<Collider2D>();
            Collider2D coll_pumpkin_s = s_pumpkin.GetComponent<Collider2D>();
            Collider2D coll_twitter_s = s_twitter.GetComponent<Collider2D>();
            Collider2D coll_scooter_s = s_scooter.GetComponent<Collider2D>();
            Collider2D coll_hover_s = s_hover.GetComponent<Collider2D>();
            Collider2D coll_car_s = s_car.GetComponent<Collider2D>();
            Collider2D coll_engineer_s = s_engineer.GetComponent<Collider2D>();
            Collider2D coll_mario_s = s_mario.GetComponent<Collider2D>();
            Collider2D coll_luffy_s = s_luffy.GetComponent<Collider2D>();
            Collider2D coll_sayian_s = s_sayian.GetComponent<Collider2D>();
            if (coll_c.OverlapPoint(wp))
            {
                v_p_c();
            }
            else if (coll_r.OverlapPoint(wp))
            {
                v_p_r();
            }
            else if (coll_y.OverlapPoint(wp))
            {
                v_p_y();
            }
            else if (coll_b.OverlapPoint(wp))
            {
                v_p_b();
            }
            else if (coll_Sports.OverlapPoint(wp))
            {
                v_p_Sports();
            }
            else if (coll_pumpkin.OverlapPoint(wp))
            {
                v_p_pumpkin();
            }
            else if (coll_twitter.OverlapPoint(wp))
            {
                v_p_twitter();
            }
            else if (coll_scooter.OverlapPoint(wp))
            {
                v_p_scooter();
            }
            else if (coll_hover.OverlapPoint(wp))
            {
                v_p_hover();
            }
            else if (coll_car.OverlapPoint(wp))
            {
                v_p_car();
            }
            else if (coll_engineer.OverlapPoint(wp))
            {
                v_p_engineer();
            }
            else if (coll_mario.OverlapPoint(wp))
            {
                v_p_mario();
            }
            else if (coll_luffy.OverlapPoint(wp))
            {
                v_p_luffy();
            }
            else if (coll_sayian.OverlapPoint(wp))
            {
                v_p_sayian();
            }
            else if (coll_c_s.OverlapPoint(wp))
            {
                v_s_c();
            }
            else if (coll_r_s.OverlapPoint(wp))
            {
                v_s_r();
            }
            else if (coll_y_s.OverlapPoint(wp))
            {
                v_s_y();
            }
            else if (coll_b_s.OverlapPoint(wp))
            {
                v_s_b();
            }
            else if (coll_Sports_s.OverlapPoint(wp))
            {
                v_s_Sports();
            }
            else if (coll_pumpkin_s.OverlapPoint(wp))
            {
                v_s_pumpkin();
            }
            else if (coll_twitter_s.OverlapPoint(wp))
            {
                v_s_twitter();
            }
            else if (coll_scooter_s.OverlapPoint(wp))
            {
                v_s_scooter();
            }
            else if (coll_hover_s.OverlapPoint(wp))
            {
                v_s_hover();
            }
            else if (coll_car_s.OverlapPoint(wp))
            {
                v_s_car();
            }
            else if (coll_engineer_s.OverlapPoint(wp))
            {
                v_s_engineer();
            }
            else if (coll_mario_s.OverlapPoint(wp))
            {
                v_s_mario();
            }
            else if (coll_luffy_s.OverlapPoint(wp))
            {
                v_s_luffy();
            }
            else if (coll_sayian_s.OverlapPoint(wp))
            {
                v_s_sayian();
            }
        }
        
        if (selector != 1 && c_int == 1)
        {
            p_c.SetActive(false);
            s_c.SetActive(true);
            sed_c.SetActive(false);
        }
        if (selector != 2 && r_int == 1)
        {
            p_r.SetActive(false);
            s_r.SetActive(true);
            sed_r.SetActive(false);
        }
        if (selector != 3 && y_int == 1)
        {
            p_y.SetActive(false);
            s_y.SetActive(true);
            sed_y.SetActive(false);
        }
        if (selector != 4 && b_int == 1)
        {
            p_b.SetActive(false);
            s_b.SetActive(true);
            sed_b.SetActive(false);
        }
        if (selector != 5 && S_int == 1)
        {
            p_Sports.SetActive(false);
            s_Sports.SetActive(true);
            sed_Sports.SetActive(false);
        }
        if (selector != 6 && p_int == 1)
        {
            p_pumpkin.SetActive(false);
            s_pumpkin.SetActive(true);
            sed_pumpkin.SetActive(false);
        }
        if (selector != 7 && t_int == 1)
        {
            p_twitter.SetActive(false);
            s_twitter.SetActive(true);
            sed_twitter.SetActive(false);
        }
        if (selector != 8 && sc_int == 1)
        {
            p_scooter.SetActive(false);
            s_scooter.SetActive(true);
            sed_scooter.SetActive(false);
        }
        if (selector != 9 && h_int == 1)
        {
            p_hover.SetActive(false);
            s_hover.SetActive(true);
            sed_hover.SetActive(false);
        }
        if (selector != 10 && car_int == 1)
        {
            p_car.SetActive(false);
            s_car.SetActive(true);
            sed_car.SetActive(false);
        }
        if (selector != 11 && e_int == 1)
        {
            p_engineer.SetActive(false);
            s_engineer.SetActive(true);
            sed_engineer.SetActive(false);
        }
        if (selector != 12 && m_int == 1)
        {
            p_mario.SetActive(false);
            s_mario.SetActive(true);
            sed_mario.SetActive(false);
        }
        if (selector != 13 && l_int == 1)
        {
            p_luffy.SetActive(false);
            s_luffy.SetActive(true);
            sed_luffy.SetActive(false);
        }
        if (selector != 14 && sayian_int == 1)
        {
            p_sayian.SetActive(false);
            s_sayian.SetActive(true);
            sed_sayian.SetActive(false);
        }
    }
    
    public void v_p_c()
    {
        if (money >= 0)
        {
            p_c.SetActive(false);
            s_c.SetActive(true);
            purchased_c = true;
            c_int = 1;
            PlayerPrefs.SetInt("classic", c_int);
        }
    }
    public void v_s_c()
    {
        if (purchased_c == true || selector == 1 || c_int == 1)
        {
            s_c.SetActive(false);
            sed_c.SetActive(true);
            selected_c = true;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 1;
        }

    }
    
    
    public void v_p_r()
    {
        if (money >= 500)
        {
            p_r.SetActive(false);
            s_r.SetActive(true);
            purchased_r = true;
            money -= 500;
            r_int = 1;
            PlayerPrefs.SetInt("red", r_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_r()
    {
        if (purchased_r == true || selector == 2 || r_int == 1)
        {
            s_r.SetActive(false);
            sed_r.SetActive(true);
            selected_c = false;
            selected_r = true;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 2;
        }

    }
    
    
    public void v_p_y()
    {
        if (money >= 500)
        {
            p_y.SetActive(false);
            s_y.SetActive(true);
            purchased_y = true;
            money -= 500;
            y_int = 1;
            PlayerPrefs.SetInt("yellow", y_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_y()
    {
        if (purchased_y == true || selector == 3 || y_int == 1)
        {
            s_y.SetActive(false);
            sed_y.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = true;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 3;
        }
        
    }
    
    
    public void v_p_b()
    {
        if (money >= 500)
        {
            p_b.SetActive(false);
            s_b.SetActive(true);
            purchased_b = true;
            money -= 500;
            b_int = 1;
            PlayerPrefs.SetInt("blue", b_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_b()
    {
        if (purchased_b == true || selector == 4 || b_int == 1)
        {
            s_b.SetActive(false);
            sed_b.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = true;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 4;
        }
        
    }
    
        public void v_p_Sports()
    {
        if (money >= 1000)
        {
            p_Sports.SetActive(false);
            s_Sports.SetActive(true);
            purchased_Sports = true;
            money -= 1000;
            S_int = 1;
            PlayerPrefs.SetInt("sports", S_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    
    public void v_s_Sports()
    {
        if (purchased_Sports == true || selector == 5 || S_int == 1)
        {
            s_Sports.SetActive(false);
            sed_Sports.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = true;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 5;
        }
        
    }
    
        public void v_p_pumpkin()
    {
        if (money >= 1000)
        {
            p_pumpkin.SetActive(false);
            s_pumpkin.SetActive(true);
            purchased_pumpkin = true;
            money -= 1000;
            p_int = 1;
            PlayerPrefs.SetInt("pumpkin", p_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_pumpkin()
    {
        if (purchased_pumpkin == true || selector == 6 || p_int == 1)
        {
            s_pumpkin.SetActive(false);
            sed_pumpkin.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = true;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 6;
        }
        
    }
    public void v_p_twitter()
    {
        if (money >= 2000)
        {
            p_twitter.SetActive(false);
            s_twitter.SetActive(true);
            purchased_twitter = true;
            money -= 2000;
            t_int = 1;
            PlayerPrefs.SetInt("twitter", t_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_twitter()
    {
        if (purchased_twitter == true || selector == 7 || t_int == 1)
        {
            s_twitter.SetActive(false);
            sed_twitter.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = true;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 7;
        }
        
    }
    
    public void v_p_scooter()
    {
        if (money >= 1500)
        {
            p_scooter.SetActive(false);
            s_scooter.SetActive(true);
            purchased_scooter = true;
            money -= 1500;
            sc_int = 1;
            PlayerPrefs.SetInt("scooter", sc_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_scooter()
    {
        if (purchased_scooter == true || selector == 8 || sc_int == 1)
        {
            s_scooter.SetActive(false);
            sed_scooter.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = true;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 8;
        }
        
    }
    
    public void v_p_hover()
    {
        if (money >= 2500)
        {
            p_hover.SetActive(false);
            s_hover.SetActive(true);
            purchased_hover = true;
            money -= 100;
            h_int = 1;
            PlayerPrefs.SetInt("hover", h_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_hover()
    {
        if (purchased_hover == true || selector == 9 || h_int == 1)
        {
            s_hover.SetActive(false);
            sed_hover.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = true;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 9;
        }
        
    }
    public void v_p_car()
    {
        if (money >= 3000)
        {
            p_car.SetActive(false);
            s_car.SetActive(true);
            purchased_car = true;
            money -= 3000;
            car_int = 1;
            PlayerPrefs.SetInt("car", car_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_car()
    {
        if (purchased_car == true || selector == 10 || car_int == 1)
        {
            s_car.SetActive(false);
            sed_car.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = true;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 10;
        }
        
    }
    
        public void v_p_engineer()
    {
        if (money >= 3500)
        {
            p_engineer.SetActive(false);
            s_engineer.SetActive(true);
            purchased_engineer = true;
            money -= 3500;
            e_int = 1;
            PlayerPrefs.SetInt("engineer", e_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_engineer()
    {
        if (purchased_engineer == true || selector == 11 || e_int == 1)
        {
            s_engineer.SetActive(false);
            sed_engineer.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = true;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = false;
            selector = 11;
        }
        
    }
    
        public void v_p_mario()
    {
        if (money >= 100)
        {
            p_mario.SetActive(false);
            s_mario.SetActive(true);
            purchased_mario = true;
            money -= 100;
            m_int = 1;
            PlayerPrefs.SetInt("mario", m_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_mario()
    {
        if (purchased_mario == true || selector == 12 || m_int == 1)
        {
            s_mario.SetActive(false);
            sed_mario.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = true;
            selected_luffy = false;
            selected_sayian = false;
            selector = 12;
        }
        
    }
    public void v_p_luffy()
    {
        if (money >= 100)
        {
            p_luffy.SetActive(false);
            s_luffy.SetActive(true);
            purchased_luffy = true;
            money -= 100;
            l_int = 1;
            PlayerPrefs.SetInt("luffy", l_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_luffy()
    {
        if (purchased_luffy == true || selector == 13 || l_int == 1)
        {
            s_luffy.SetActive(false);
            sed_luffy.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = true;
            selected_sayian = false;
            selector = 13;
        }
        
    }
    public void v_p_sayian()
    {
        if (money >= 100)
        {
            p_sayian.SetActive(false);
            s_sayian.SetActive(true);
            purchased_sayian = true;
            money -= 100;
            sayian_int = 1;
            PlayerPrefs.SetInt("sayian", sayian_int);
            FindObjectOfType<Audiomanager>().playsound("purchase");
        }
    }
    public void v_s_sayian()
    {
        if (purchased_sayian == true || selector == 14 || sayian_int == 1)
        {
            s_sayian.SetActive(false);
            sed_sayian.SetActive(true);
            selected_c = false;
            selected_r = false;
            selected_y = false;
            selected_b = false;
            selected_Sports = false;
            selected_pumpkin = false;
            selected_twitter = false;
            selected_scooter = false;
            selected_hover = false;
            selected_car = false;
            selected_engineer = false;
            selected_mario = false;
            selected_luffy = false;
            selected_sayian = true;
            selector = 14;
        }
        
    }
    
    public void play()
    {
        SceneManager.LoadScene(2);
    }
    public void menu_go()
    {
        SceneManager.LoadScene(1);
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("money", money); 
    }
}