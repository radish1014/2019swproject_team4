﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Click_Sound : MonoBehaviour
{
    public AudioSource Button;
    public AudioClip Click;


    public void ClickSound()
    {
        Button.PlayOneShot(Click);
    }
}