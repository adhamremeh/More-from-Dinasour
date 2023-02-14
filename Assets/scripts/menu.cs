using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    
    public void playgame()
    {
        SceneManager.LoadScene(4);
    }
        public void shop()
    {
        retry.inte = 0;
        SceneManager.LoadScene(3);
    }
    
    public void quitgame()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
