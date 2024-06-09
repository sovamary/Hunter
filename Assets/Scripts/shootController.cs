using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootController : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    private Quaternion bulletRotation;
    void Update()
    {
        bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 272);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, barrel.position, bulletRotation);
        }

    }
}
