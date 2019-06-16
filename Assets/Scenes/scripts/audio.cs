using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audio : MonoBehaviour
{
    AudioSource one;
    // Start is called before the first frame update
    void Start()
    {
        one = GetComponent<AudioSource>();

        if (one.isPlaying)
        {
            one.Stop();
        }
        one.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
