using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchButton_RefrigeratorScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void refrigerator_BackButton_ChangeScene()
    {
        Debug.Log("refrigerator_backbutton");
        SceneManager.LoadScene("Select_Scene");
    }
}
