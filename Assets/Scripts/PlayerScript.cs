using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject otherPlayer;

    void OnMouseDown()
    {
        otherPlayer.GetComponent<DoubleJump>().enabled = false;
        GetComponent<Car>().enabled = true;
    }


}
