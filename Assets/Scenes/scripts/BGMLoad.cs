using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMLoad : MonoBehaviour
{
    public AudioClip BGM;
    AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (!audio.isPlaying)
        {
            audio.clip = BGM;
            audio.Play();
        }
    
    }
}