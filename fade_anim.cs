//You can change the if statment to whatever you want. It does not have to be a key input.
//Also make sure that your animation are not set to loop. You can turn it off by checking off the box that says loop. I show this in the video.

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
