using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class PlaySoundOnEnter : MonoBehaviour
{
    Collectible collectible; 
    AudioSource source;

    Collider soundTrigger;


    void Awake() 
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider collider) {
        if ( collider.gameObject.tag == "Player")
        source.Play();

        if (collectible != null); source.Play();

         
    }
    
}

//void OnTriggerEnter(Collider collider) {
//source.Play();
//will play when player leaves it