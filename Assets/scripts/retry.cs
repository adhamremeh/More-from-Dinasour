using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{

   public static int inte = 0;

    public static int ADs = 0;

    public GameObject timees;

    public void retry_()
    {
        inte = 1;
        ADs++; 
        if(ADs > 1)
        {
            ADs = 0;
            FindObjectOfType<AdControllerF>().PlayAD();
        }
        
        SceneManager.LoadScene(3);
        SceneManager.LoadScene(2);  
        Time.timeScale = 1;
        timees.SetActive(true);
    }
    public void shop_()
    {
        ADs++;
        inte = 1;
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void menu_()
    {
        inte = 1;
        SceneManager.LoadScene(3);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void timesTwo()
    {
        FindObjectOfType<AdControllerF>().PlayRewardedAD();
    }
}