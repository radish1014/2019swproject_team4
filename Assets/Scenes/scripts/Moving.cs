using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    bool move, _combine;
    int _x2, _y2;

    void Update(){
        if (move) Move(_x2, _y2, _combine);
    }

    public void Move(int x2, int y2, bool combine) {
        move = true;
        _combine = combine;
        _x2 = x2;
        _y2 = y2;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3((1.79f * x2) - 5.122f,(1.79f * y2) - 2.816f, -1), 0.5f);
        if (transform.position == new Vector3((1.79f * x2) - 5.122f, (1.79f * y2) - 2.816f, -1)) {
            move = false;
            if (combine) {
                _combine = false;
                Destroy(gameObject);
            }
        }

    }
}
