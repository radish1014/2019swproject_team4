using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_Chapter_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Chapter_2_BackButton_ChangeScene()
    {
        Debug.Log("Chapter_2_backbutton");
        SceneManager.LoadScene("Select_Scene");
    }
}