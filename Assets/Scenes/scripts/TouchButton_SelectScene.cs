using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_SelectScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void select_BackButton_ChangeScene()
    {
        Debug.Log("select_backbutton");
        SceneManager.LoadScene("ModeSelect_Scene");
    }
    public void select_Stage1Button_ChangeScene()
    {
        Debug.Log("select_stage1button");
        SceneManager.LoadScene("Chapter_1_Start");
        //1스테이지로 이동
    }
    public void select_Stage2Button_ChangeScene()
    {
        Debug.Log("select_stage2button");
        SceneManager.LoadScene("Chapter_2_Start");
        //2스테이지로 이동
    }
    public void select_Stage3Button_ChangeScene()
    {
        Debug.Log("select_stage3button");
        //SceneManager.LoadScene("ModeSelect_Scene");
        //3스테이지로 이동
    }
    public void select_RefrigertorButton_ChangeScene()
    {
        Debug.Log("select_refrigeratorbutton");
        SceneManager.LoadScene("Refrigerator_Scene");
        //냉창고로 이동
    }
}

