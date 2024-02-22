using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource narrator2;
    [SerializeField] AudioSource part1song;
    [SerializeField] AudioSource part2song;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectible")
        {
            part1song.Stop();

            StartCoroutine(MusicManager());
        }
    }

    private void Update()
    {
        
    }

    IEnumerator MusicManager()
    {
        yield return new WaitForSeconds(0.1f);
        if (part1song.isPlaying == false)
        {
            narrator2.Play();
            yield return new WaitForSeconds(3f);
            if (narrator2.isPlaying == false)
            {
                part2song.Play();
            }
        }
    }
}
