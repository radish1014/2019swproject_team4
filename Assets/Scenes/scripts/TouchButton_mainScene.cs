using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_mainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void main_StartButton_ChangeScene() {
        Debug.Log("main_startbutton");
        SceneManager.LoadScene("ModeSelect_Scene");
    }

    public void main_SettingButton_ChangeScene()
    {
        Debug.Log("main_settingbutton");
        SceneManager.LoadScene("Setting_Scene");
    }
    public void main_ExitButton_ChangeScene()
    {
        Debug.Log("main_exitbutton");
        //SceneManager.LoadScene("ModeSelect_Scene");
        //게임종료
    }
}
