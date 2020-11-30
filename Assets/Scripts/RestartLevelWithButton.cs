using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{

    [SerializeField]
    KeyCode keyRestart;
    [SerializeField]
    KeyCode keyEsc;

    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(keyEsc))
        {
            SceneManager.LoadScene(0);
        }
    }
}
