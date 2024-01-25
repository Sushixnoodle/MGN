using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthCollectible : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;
    public string objectID;
    bool toggle;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start()
    {
        if (PlayerPrefs.HasKey(objectID) && PlayerPrefs.GetInt(objectID, 1) == 1)
        {
            toggle = true;
        }
        UpdateCount();
    }

    void OnEnable()
    {
        Collectible.OnCollected += OnCollectibleCollected;
        PlayerPrefs.SetInt(objectID, 0);
        PlayerPrefs.Save();

    }

    void OnDisable()
    {
        Collectible.OnCollected -= OnCollectibleCollected;
    }

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        // Check if 'text' is not null before updating its text property
        if (text != null)
        {
            text.text = $"4 / " + "5";


            Debug.Log($"Updated count: {count}, Total: " + "5");
        }
        else
        {
            Debug.LogWarning("Text component is not assigned in the CollectibleCounter script.");
        }
        PlayerPrefs.SetInt(objectID, 0);
        PlayerPrefs.Save();
    }
}