using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CursorLockExample : MonoBehaviour
{
    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.Mouse0))
            Cursor.lockState = CursorLockMode.None;
        {
            Debug.Log("Mouse 0 ");
        }
    }
}