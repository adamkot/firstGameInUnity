using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWhenFall : MonoBehaviour
{
    [SerializeField]
    int positionYToRestart;
    [SerializeField]
    TMP_Text lifeText;

    void Update()
    {
        lifeText.text = GameManager.instance.lifes.ToString();
        if (GetComponent<Rigidbody>().position.y < positionYToRestart)
        {
            Death();
        }
    }

    private void Death()
    {
        GameManager.instance.DecrementLifes();
        if (GameManager.instance.lifes < 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
