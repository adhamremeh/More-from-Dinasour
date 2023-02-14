using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class LOADZEROSCENE : MonoBehaviour
{
    private void Awake()
    {
        shop.money = PlayerPrefs.GetInt("money");
        scoreandhighscore.highscore_int = PlayerPrefs.GetInt("highscore");
        shop.c_int = PlayerPrefs.GetInt("classic");
        shop.r_int = PlayerPrefs.GetInt("red");
        shop.y_int = PlayerPrefs.GetInt("yellow");
        shop.b_int = PlayerPrefs.GetInt("blue");
        shop.S_int = PlayerPrefs.GetInt("sports");
        shop.p_int = PlayerPrefs.GetInt("pumpkin");
        shop.sc_int = PlayerPrefs.GetInt("scooter");
        shop.t_int = PlayerPrefs.GetInt("twitter");
        shop.h_int = PlayerPrefs.GetInt("hover");
        shop.car_int = PlayerPrefs.GetInt("car");
        shop.e_int = PlayerPrefs.GetInt("engineer");
        shop.m_int = PlayerPrefs.GetInt("mario");
        shop.l_int = PlayerPrefs.GetInt("luffy");
        shop.sayian_int = PlayerPrefs.GetInt("sayian");
        SceneManager.LoadScene(1);
    }
}
