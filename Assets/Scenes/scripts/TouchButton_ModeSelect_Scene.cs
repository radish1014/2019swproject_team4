using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_ModeSelect_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void modeselect_BackButton_ChangeScene()
    {
        Debug.Log("modeselect_backbutton");
        SceneManager.LoadScene("main");
    }
    public void modeselect_StoryButton_ChangeScene()
    {
        Debug.Log("modeselect_storybutton");
        SceneManager.LoadScene("Select_Scene");
    }
    public void modeselect_ScoreButton_ChangeScene()
    {
        Debug.Log("modeselect_scorebutton");
        SceneManager.LoadScene("Ranking_Scene");
        
    }
}
