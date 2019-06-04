using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_SettingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setting_BackButton_ChangeScene()
    {
        Debug.Log("setting_backbutton");
        SceneManager.LoadScene("main");
    }
}
