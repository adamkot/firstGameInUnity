using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMP : MonoBehaviour
{
    [SerializeField]
    TMP_Text clockText;
    private float time;


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        clockText.text = Math.Round(time, 2).ToString();
    }
}
