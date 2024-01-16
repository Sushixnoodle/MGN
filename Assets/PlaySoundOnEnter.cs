using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class PlaySoundOnEnter : MonoBehaviour
{

    AudioSource source;

    Collider soundTrigger;


    void Awake() {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider collider) 
    {
        if ( collider.gameObject.tag == "Player")
        {
            Debug.Log("Sound is working");
            source.Play();
        }
        
    }
    
}

//void OnTriggerEnter(Collider collider) {
//source.Play();
//will play when player leaves it