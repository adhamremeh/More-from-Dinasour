using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerthehover : MonoBehaviour
{
        private Animator anim_;
        
    // Start is called before the first frame update
    void Start()
    {
                anim_ = GetComponent<Animator>();
        anim_.SetTrigger("hover");
    }

}
