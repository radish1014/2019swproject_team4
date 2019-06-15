using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chapter_GameManager : MonoBehaviour
{

    public GameObject[] n;
    public GameObject Quit;
    public GameObject Success;



    int x, y, i, j, k, l;
    GameObject[,] Square = new GameObject[4, 4];
    Vector3 keyPos;

    bool wait, move, stop=false;

    void Start(){
        Spawn();
        Spawn();
       
    }
    void Update()
    {
        if (stop) return;

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            for (y = 0; y <= 3; y++) for (x = 3; x >= 1; x--) for (i = 0; i <= x - 1; i++) MoveorCombine(i + 1, y, i, y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            for (y = 0; y <= 3; y++) for (x = 0; x <= 2; x++) for (i = 3; i >= x + 1; i--) MoveorCombine(i - 1, y, i, y);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            for (x = 0; x <= 3; x++) for (y = 0; y <= 2; y++) for (i = 3; i >= y + 1; i--) MoveorCombine(x, i - 1, x, i);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            for (x = 0; x <= 3; x++) for (y = 3; y >= 1; y--) for (i = 0; i <= y - 1; i++) MoveorCombine(x, i + 1, x, i);
        }
        else return;

        if (move){
            move = false;
            Spawn();
            k = 0;
            l = 0;
            for (x = 0; x <= 3; x++)
            {
                for (y = 0; y <= 3; y++)
                {
                    //타일 꽉차면 k 0됨
                    if (Square[x, y] == null) { k++; continue; }
                    if (Square[x, y].tag == "Combine") Square[x, y].tag = "Untagged";
                }
            }
            if (k == 0){

                for (y = 0; y <= 3; y++) for (x = 0; x <= 2; x++) if (Square[x, y].name == Square[x + 1, y].name) l++;
                for (x = 0; x <= 3; x++) for (y = 0; y <= 2; y++) if (Square[x, y].name == Square[x, y + 1].name) l++;
                {

                    stop = true; Quit.SetActive(true); return;
                }
            }
        }
    }

    //이동 혹 결합하는 함수
    //x1,y1 = 이동전 좌표, x2, y2 = 이동 후 좌표
    void MoveorCombine(int x1, int y1, int x2, int y2)
    {
        //이동될좌표 빔 && 이동전좌표에 존재 == 이동함
        if (Square[x2, y2] == null && Square[x1, y1] != null)
        {
            move = true;
            Square[x1, y1].GetComponent<Moving>().Move(x2, y2, false);
            Square[x2, y2] = Square[x1, y1];
            Square[x1, y1] = null;
        }

        //둘다 같은 수일때 결합
        if (Square[x1, y1] != null && Square[x2, y2] != null && Square[x1, y1].name == Square[x2, y2].name && Square[x1, y1].tag != "Combine" && Square[x2, y2].tag != "Combine")
        {
            move = true;
            for (j = 0; j <= 11; j++)
            {
                if (Square[x2, y2].name == n[j].name + "(Clone)") break;
            }
            Square[x1, y1].GetComponent<Moving>().Move(x2, y2, true);
            Destroy(Square[x2, y2]);
            Square[x1, y1] = null;
            Square[x2, y2] = Instantiate(n[j + 1], new Vector3((1.79f * x2) - 5.122f, (1.79f * y2) - 2.816f, -1), Quaternion.identity);
            Square[x2, y2].tag = "Combine";
            Square[x2, y2].GetComponent<Animator>().SetTrigger("Combine");
            if (Square[x2, y2].name == n[3].name+"(Clone)")
            {
                stop = true; Success.SetActive(true); return;
            }
        }

        

    }


    void Spawn()
    {
        while (true)
        {
            x = Random.Range(0, 4);
            y = Random.Range(0, 4);
            if (Square[x, y] == null) break;
        }
        Square[x, y] = Instantiate(Random.Range(0, 8) > 0 ? n[0] : n[1], new Vector3((1.79f * x) - 5.122f, (1.79f * y) - 2.816f, -1), Quaternion.identity);
        Square[x, y].GetComponent<Animator>().SetTrigger("Spawn_new");
    }


    //재시작
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit_back() {
        SceneManager.LoadScene("Select_Scene");
    }
    public void Success_next_chapter1() {
        SceneManager.LoadScene("Chapter_1_Ending");
    }
    public void Success_next_chapter2()
    {
        SceneManager.LoadScene("Chapter_2_Ending");
    }
    public void Success_next_chapter3()
    {
        SceneManager.LoadScene("Chapter_3_Ending");
    }
}


