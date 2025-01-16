using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += 0.2f;
        transform.eulerAngles = rot;

        Vector3 roT = transform.eulerAngles;
        roT.z += 0.1f;
        transform.eulerAngles = roT;
    }
}
