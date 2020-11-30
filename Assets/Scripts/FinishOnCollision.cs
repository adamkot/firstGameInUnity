using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishOnCollision : MonoBehaviour
{
    [SerializeField]
    TMP_Text textFinish;

    void OnCollisionEnter(Collision collision)
    {
        textFinish.text = "FINISH!\nEsc to exit";
        Destroy(collision.gameObject);
    }
}
