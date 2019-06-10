using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class Test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    

    private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
    }


    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;
        Debug.Log("count="+ count);

    }

    void Start() {

        OnOff(true);
        count = 0;
        NextDialogue();
        Debug.Log("돌아가는중");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("count=" + count);
        Debug.Log("dialogue.Length=" + dialogue.Length);
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            if (count < dialogue.Length) NextDialogue();
            else OnOff(false);
        }
        
    }
}