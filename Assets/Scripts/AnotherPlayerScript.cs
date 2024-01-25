using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherPlayerScript : MonoBehaviour
{
    public GameObject otherPlayer;

    void OnMouseDown()
    {
        otherPlayer.GetComponent<Car>().enabled = false;
        GetComponent<DoubleJump>().enabled = true;
    }


}
