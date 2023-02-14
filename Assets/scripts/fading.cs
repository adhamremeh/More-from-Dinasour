using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour
{
            private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreandhighscore.fading == true)
        {
            anim.SetBool("fading", true);
        }
        else if(scoreandhighscore.fading == false)
        {
            anim.SetBool("fading", false);
        }
    }
}
