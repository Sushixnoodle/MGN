using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnotherSpecificScene : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(2);
    }

}
