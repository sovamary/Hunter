using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePaimon : MonoBehaviour
{

    private int speed = 15;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
