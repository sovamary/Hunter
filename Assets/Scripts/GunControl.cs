using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{

    private float horizontal;
   // private float vertical;
    private float sensitivity = 2;




    void Start()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

        horizontal = Input.GetAxis("Mouse X") * sensitivity;
      //  vertical = Input.GetAxis("Mouse Y") * sensitivity;
        transform.Rotate(0, horizontal, 0);
       //  transform.Rotate(0,0,vertical);

    }
}
