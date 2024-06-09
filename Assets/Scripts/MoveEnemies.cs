using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemies : MonoBehaviour
{

    private int speed = 15;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
