using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_anim : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("fadeOut");
        }
    }
}
