using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartName : MonoBehaviour
{

    public GameObject partNameText;

    private void Start()
    {
        partNameText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            partNameText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            partNameText.SetActive(false);
        }
    }
}