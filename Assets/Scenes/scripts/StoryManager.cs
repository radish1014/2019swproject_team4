using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string log;
    public Sprite cg;
}

public class StoryManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_textBox;
    [SerializeField] private SpriteRenderer sprite_standingCG;
    [SerializeField] private Text txt_dialogue;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    private void story(bool _flag)
    {
        sprite_textBox.gameObject.SetActive(_flag);
        sprite_standingCG.gameObject.SetActive(_flag);
        txt_dialogue.gameObject.SetActive(_flag);
    }

    private void Nextlog()
    {
        txt_dialogue.text = dialogue[count].log;
        sprite_standingCG.sprite = dialogue[count].cg;
        count++;
        Debug.Log("count="+ count);
    }

    void Start()
    {
        story(true);
        count = 0;
        Nextlog();
    }

    void Update()
    {
        Debug.Log("count=" + count);
        Debug.Log("dialogue.Length=" + dialogue.Length);
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            if (count < dialogue.Length) Nextlog();
            else
            {
                story(false);
                if (SceneManager.GetActiveScene().name == "Chapter_1_Start") // 챕터1 게임시작
                    SceneManager.LoadScene("Chapter_1");
                else if (SceneManager.GetActiveScene().name == "Chapter_1_Ending") // 챕터1 클리어
                    SceneManager.LoadScene("Select_Scene");

                else if (SceneManager.GetActiveScene().name == "Chapter_2_Start") // 챕터2 게임시작
                    SceneManager.LoadScene("Chapter_2");
                else if (SceneManager.GetActiveScene().name == "Chapter_2_Ending") // 챕터2 클리어
                    SceneManager.LoadScene("Select_Scene");

                if (SceneManager.GetActiveScene().name == "Chapter_3_Start") // 챕터3 게임시작
                    SceneManager.LoadScene("Chapter_3");
                else if (SceneManager.GetActiveScene().name == "Chapter_3_Ending") // 챕터3 클리어
                    SceneManager.LoadScene("Select_Scene");
            }
        }
    }
}