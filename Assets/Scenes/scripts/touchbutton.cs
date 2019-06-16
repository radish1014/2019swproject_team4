using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gomain_ChangeScene()
    {
        SceneManager.LoadScene("main");
        //메인화면으로이동
    }
    public void gosetting_ChangeScene() {
        SceneManager.LoadScene("Setting_Scene");
        //셋팅화면으로 이동
    }

    public void gomodeselect_ChangeScene()
    {
        SceneManager.LoadScene("ModeSelect_Scene");
        //모드선택화면으로 이동
    }
    public void goselect_ChangeScene() {
        SceneManager.LoadScene("Select_Scene");
        //챕터선택화면으로 이동
    }
    public void goscoremode_ChangeScene()
    {
        SceneManager.LoadScene("ScoreMode_Scene");
        //스코어모드 화면으로 이동
    }
    public void gochapter1_ChangeScene()
    {
        SceneManager.LoadScene("Chapter_1_Start");
        //1스테이지로 이동
    }
    public void gochapter2_ChangeScene()
    {
        SceneManager.LoadScene("Chapter_2_Start");
        //2스테이지로 이동
    }
    public void gochapter3_ChangeScene()
    {
        SceneManager.LoadScene("Chapter_3_Start");
        //3스테이지로 이동
    }
    public void goend() {
        Application.Quit();
        //게임종료
    }
    

}
