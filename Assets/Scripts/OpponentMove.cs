using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentMove : MonoBehaviour
{
    Rigidbody rig;

    [SerializeField]
    float MaxAngleDeflection;
    [SerializeField]
    float SpeedOfPendulum;
    float angle;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        angle = MaxAngleDeflection * Mathf.Sin(Time.timeSinceLevelLoad * SpeedOfPendulum);
        rig.velocity = new Vector3(0, 0, angle);
    }
}
