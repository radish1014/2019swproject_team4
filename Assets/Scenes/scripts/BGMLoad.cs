using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMLoad : MonoBehaviour
{
    private static BGMLoad instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        
    }
    void Update() {
        
        

    }

}