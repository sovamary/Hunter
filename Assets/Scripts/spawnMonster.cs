using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMonster : MonoBehaviour
{
    public GameObject[] monsters;
   // private int index;
    private Vector3 position;
    private int startSpawn = 2;
    private int spawnRepeat = 4;
    private void Start()
    {
        InvokeRepeating("Spawn", startSpawn, spawnRepeat);
    }




    void Spawn()
          {   
       // index = Random.Range(0, monsters.Length);

        for(int i = 0; i < monsters.Length; i++)
        {

        position = new Vector3(Random.Range(40,95),5,Random.Range(82,200));
        Instantiate(monsters[i], position, monsters[i].transform.rotation);
        }

          }
    
    
    
}
