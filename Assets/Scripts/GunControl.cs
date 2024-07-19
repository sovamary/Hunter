using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    private float sensitivity = 15;

    public enum ControlTypes { keyboard, mouse}
    public ControlTypes inputControl = ControlTypes.keyboard;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (inputControl == ControlTypes.keyboard)
        {
            horizontal = Input.GetAxis("Horizontal") * sensitivity * Time.deltaTime;
            vertical = Input.GetAxis("Vertical") * sensitivity * Time.deltaTime;
        }
        else
        {
            horizontal = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            vertical = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
          
        }

        transform.Rotate(0, horizontal, 0);
        transform.Rotate(0, 0, vertical);

    }
}
