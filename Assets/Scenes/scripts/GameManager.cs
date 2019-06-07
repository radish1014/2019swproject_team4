using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] n;


    int x, y,i,j;
    GameObject[,] Square = new GameObject[4, 4];
    Vector3 keyPos;
    bool wait,move;
    //
    void Start()
    {
        Spawn();
        Spawn();
    }

    
    void Update()
    {
        
        

        if (Input.GetKeyDown(KeyCode.LeftArrow)== true){
            Debug.Log("keydown- left");
            for (y = 0; y <= 3; y++)for (x = 3; x >= 1; x--)for (i = 0; i <= x-1; i++) MoveorCombine(i + 1, y, i, y);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true){
            if (wait){
                wait = false;
                Debug.Log("keydown- right");
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) == true){
            if (wait){
                wait = false;
                Debug.Log("keydown- up");

            }

        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true){
            if (wait){
                wait = false;
                Debug.Log("keydown- down");

            }

        }


        if (move) {
            move = false;
            Spawn();
        }


    }
    //이동 혹 결합하는 함수
    //x1,y1 = 이동전 좌표, x2, y2 = 이동 후 좌표
    void MoveorCombine(int x1, int y1, int x2, int y2) {
        //이동될좌표 빔 && 이동전좌표에 존재 == 이동함
        if (Square[x2, y2] == null && Square[x1, y1] != null) {

            move = true;
            Square[x1, y1].GetComponent<Moving>().Move(x2,y2);
            Square[x2, y2] = Square[x1, y1];
            Square[x1, y1] = null;
        }

        //둘다 같은 수일때 결합
        if (Square[x1, y1] != null && Square[x2, y2] != null && Square[x1, y1].name == Square[x2, y2].name && Square[x1, y1].tag != "Combine" && Square[x2, y2].tag != "Combine") {
            move = true;
            for (j = 0; j <= 11; j++){
                if (Square[x2, y2].name == n[j].name + "(Clone)") break;
            }
            Square[x1, y1].GetComponent<Moving>().Move(x2, y2);
            Destroy(Square[x2, y2]);
            Square[x1, y1] = null;
            Square[x2, y2] = Instantiate(n[j + 1], new Vector3((1.79f * x2) - 5.122f, (1.79f * y2) - 2.816f, -1), Quaternion.identity);

            
        }

    }


    void Spawn()
    {
        while (true) {
            x = Random.Range(0, 4);
            y = Random.Range(0, 4);
            if (Square[x, y] == null) break; 
        }
        Square[x, y] = Instantiate(Random.Range(0, 8) > 0 ? n[0] : n[1], new Vector3((1.79f * x) - 5.122f, (1.79f * y) - 2.816f, -1), Quaternion.identity);
        Square[x, y].GetComponent<Animator>().SetTrigger("Spawn_new");
    }


    //재시작
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

