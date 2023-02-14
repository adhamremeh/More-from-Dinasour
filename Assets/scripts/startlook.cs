using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startlook : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(load());
        StartCoroutine(run());
    }
    
    IEnumerator load()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
    IEnumerator run()
    {
        yield return new WaitForSeconds(1.2f);
        FindObjectOfType<Audiomanager>().playsound("run");
    }
}
