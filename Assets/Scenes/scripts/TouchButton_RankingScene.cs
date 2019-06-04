using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_RankingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ranking_BackButton_ChangeScene() {
        Debug.Log("ranking_backbutton");
        SceneManager.LoadScene("ModeSelect_Scene");
    }

    public void ranking_GameStartButton_ChangeScene()
    {
        Debug.Log("ranking_gamestartbutton");
        SceneManager.LoadScene("ScoreMode_Scene");
    }
}
