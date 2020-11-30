using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointCollision : MonoBehaviour
{
    [SerializeField]
    TMP_Text clockText;

    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        int points = Int32.Parse(clockText.text);
        points++;
        clockText.text = points.ToString();
    }
}
