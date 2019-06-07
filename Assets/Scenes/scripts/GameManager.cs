using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] n;

    int x, y;
    GameObject[,] Square = new GameObject[4, 4];

    void Start()
    {
        Spawn();
        Spawn();
    }

    
    void Update()
    {
        
    }

    void Spawn()
    {

        while (true)
        {
            x = Random.Range(0, 4);
            y = Random.Range(0, 4);
            if (Square[x, y] == null) break;
            
        }

        Debug.Log("x = " + x + ", y = " + y);
        Square[x, y] = Instantiate(Random.Range(0, 8) > 0 ? n[0] : n[1], new Vector3(1.79f * x - 5.122f, 1.79f * y - 2.816f, -1), Quaternion.identity);
        //Square[x, y].GetComponent
    }


    //재시작
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

